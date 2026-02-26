using System.Text.Json.Serialization;

namespace EasyGame.Configs;

internal record ModConfigData
{
    /// <summary> 是否启用功能 </summary>
    [JsonInclude]
    public WhetherEnableFunction EnableFunction { get; set; } = new();

    /// <summary> 针剂质量与使用次数修改数据 </summary>
    [JsonInclude]
    public StimulatorConfig StimulatorConfig { get; init; } = new();

    /// <summary> 带入对局物品限制 </summary>
    [JsonInclude]
    public double EnterGameItemLimit { get; set; } = 3600;

    /// <summary> 所有存档血量倍率 </summary>
    [JsonInclude]
    public double HealthModify { get; set; } = 1.5;

    /// <summary> 所有存档能量与水分倍率 </summary>
    [JsonInclude]
    public double EnergyHydrationModify { get; set; } = 1.5;

    /// <summary> 战局时长倍率 </summary>
    [JsonInclude]
    public double RaidTimeModify { get; set; } = 3.0;

    /// <summary> 装弹时间倍率 </summary>
    [JsonInclude]
    public double TakeInAmmoTimeModify { get; set; } = 0.05;

    /// <summary> 卸弹时间倍率 </summary>
    [JsonInclude]
    public double TakeOutAmmoTimeModify { get; set; } = 0.05;

    /// <summary> 检查弹匣时间倍率 </summary>
    [JsonInclude]
    public double CheckAmmoTimeModify { get; set; } = 0.45;

    /// <summary> 每级跳蚤市场挂单上限倍率 </summary>
    [JsonInclude]
    public double MaxActiveOfferCountModify { get; set; } = 7;

    /// <summary> 实验室访问卡耐久 </summary>
    [JsonInclude]
    public int LabsAccessMaximumNumberOfUsage { get; set; } = 10;

    /// <summary> 迷宫访问卡耐久 </summary>
    [JsonInclude]
    public int LabysAccessMaximumNumberOfUsage { get; set; } = 10;

    /// <summary> 弹药堆叠 </summary>
    [JsonInclude]
    public int AmmoStack { get; set; } = 300;
}