using System.Diagnostics;
using System.Text;
using SuntionCore.Services.LogUtils;

namespace EasyGame.Tasks;

internal class ModTaskStats
{
    /// <summary> 任务是否成功 </summary>
    public bool IsSuccess { get; set; }

    /// <summary> 任务执行的毫秒数 </summary>
    public double Milliseconds { get; set; }
}

public class ModTaskMgr
{
    private readonly Dictionary<string, ModTask> _tasks = new();
    private readonly Dictionary<string, ModTaskStats> _tasksStats = new();
    public static readonly ModLogger ModLogger = 
        ModLogger.GetOrCreateLogger("EasyGame", logFileMaxSize: 120 * 1024);

    /// <summary>
    /// 添加任务
    /// </summary>
    public void AddTask(ModTask task)
    {
        if (!_tasks.TryAdd(task.Name, task))
        {
            ModLogger.Warn($"已添加过任务[{task}], 无法重复添加");
        }
    }
    
    /// <summary>
    /// 运行所有任务
    /// </summary>
    public void RunAllTasks()
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();
        List<Task> tasks = [];
        foreach (KeyValuePair<string, ModTask> modTask in _tasks.OrderBy(x => x.Value.Order).ToList())
        {
            tasks.Add(Task.Run(() => { ExecuteTask(modTask.Value); }));
        }
        Task.WaitAll(tasks.ToArray());
        var sb = new StringBuilder();
        sb.Append("任务统计信息:\n\t - ");
        sb.AppendJoin("\n\t - ", _tasksStats
            .Select(x => $"任务[{x.Key}](是否完成: {x.Value.IsSuccess}, 耗时: {x.Value.Milliseconds:F3} ms)"));
        sb.Append("\n\t * 跳过的任务: ");
        sb.AppendJoin(", ", _tasks.Keys.Where(x => !_tasksStats.ContainsKey(x)).Select(x => $"[{x}]"));
        stopwatch.Stop();
        sb.Append($"\n\t * 运行所有任务并生成统计信息耗时: {stopwatch.Elapsed.TotalMilliseconds:F3} ms");
        ModLogger.Info(sb.ToString());
    }

    public void ExecuteTask(ModTask task)
    {
        if (!task.Condition())
        {
            ModLogger.Info($"任务[{task}]已跳过, 不会执行");
            return;
        }
        Stopwatch stopwatch = new();
        stopwatch.Start();
        ModTaskStats stats = new()
        {
            IsSuccess = false,
            Milliseconds = 0
        };
        if (!_tasksStats.TryAdd(task.Name, stats))
        {
            var i = 0;
            while (!_tasksStats.TryAdd($"{task.Name}_{i}", stats))
            {
                if (i > 10)
                {
                    ModLogger.Error($"执行任务[{task.Name}]时添加统计对象时出错了, 添加了超出重试次数的相同名称的任务");
                    break;
                }
                i++;
            }
        }
        ModLogger.Debug($"开始执行任务: [{task.Name}]:");
        try
        {
            task.Callback();
            stats.IsSuccess = true;
        }
        catch (Exception e)
        {
            stopwatch.Stop();
            stats.Milliseconds = stopwatch.Elapsed.TotalMilliseconds;
            ModLogger.Error($"执行任务[{task.Name}]时出错了: {e.GetType().Name}({e.Message}), 耗时{stopwatch.Elapsed.TotalMilliseconds:F3} ms", e);
            return;
        }
        stopwatch.Stop();
        stats.Milliseconds = stopwatch.Elapsed.TotalMilliseconds;
        ModLogger.Info($"执行任务[{task.Name}]完成, 耗时{stopwatch.Elapsed.TotalMilliseconds:F3} ms");
    }
}