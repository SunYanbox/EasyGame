using System.Diagnostics;
using SuntionCore.Services.LogUtils;

namespace EasyGame.Tasks;

public class ModTaskMgr
{
    private readonly Dictionary<string, ModTask> _tasks = new();
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
        List<Task> tasks = [];
        foreach (KeyValuePair<string, ModTask> modTask in _tasks.OrderBy(x => x.Value.Order).ToList())
        {
            tasks.Add(Task.Run(() => { ExecuteTask(modTask.Value); }));
        }
        Task.WaitAll(tasks.ToArray());
    }

    private void ExecuteTask(ModTask task)
    {
        if (!task.Condition())
        {
            ModLogger.Info($"任务[{task}]已跳过, 不会执行");
            return;
        }
        Stopwatch stopwatch = new();
        ModLogger.Debug($"开始执行任务: [{task.Name}]:");
        try
        {
            task.Callback();
        }
        catch (Exception e)
        {
            stopwatch.Stop();
            ModLogger.Error($"执行任务[{task.Name}]时出错了: {e.GetType().Name}({e.Message}), 耗时{stopwatch.Elapsed.TotalMilliseconds:F3} ms", e);
            return;
        }
        stopwatch.Stop();
        ModLogger.Info($"执行任务[{task.Name}]完成, 耗时{stopwatch.Elapsed.TotalMilliseconds:F3} ms");
    }
}