using System.Text.Json.Serialization;

namespace EasyGame.Configs;

internal record ModConfigData
{
    /// <summary> 是否启用功能 </summary>
    [JsonInclude]
    public WhetherEnableFunction? EnableFunction { get; set; }

    /// <summary> 针剂质量与使用次数修改数据 </summary>
    [JsonInclude]
    public StimulatorConfig? StimulatorConfig { get; init; }

    /// <summary> 带入对局物品限制 </summary>
    [JsonInclude]
    public double EnterGameItemLimit { get; set; }

    /// <summary> 所有存档血量倍率 </summary>
    [JsonInclude]
    public double HealthModify { get; set; }

    /// <summary> 所有存档能量与水分倍率 </summary>
    [JsonInclude]
    public double EnergyHydrationModify { get; set; }

    /// <summary> 战局时长倍率 </summary>
    [JsonInclude]
    public double RaidTimeModify { get; set; }

    /// <summary> 装弹时间倍率 </summary>
    [JsonInclude]
    public double TakeInAmmoTimeModify { get; set; }

    /// <summary> 卸弹时间倍率 </summary>
    [JsonInclude]
    public double TakeOutAmmoTimeModify { get; set; }

    /// <summary> 检查弹匣时间倍率 </summary>
    [JsonInclude]
    public double CheckAmmoTimeModify { get; set; }

    /// <summary> 每级跳蚤市场挂单上限倍率 </summary>
    [JsonInclude]
    public double MaxActiveOfferCountModify { get; set; }

    /// <summary> 实验室访问卡耐久 </summary>
    [JsonInclude]
    public int LabsAccessMaximumNumberOfUsage { get; set; }

    /// <summary> 迷宫访问卡耐久 </summary>
    [JsonInclude]
    public int LabysAccessMaximumNumberOfUsage { get; set; }

    /// <summary> 弹药堆叠 </summary>
    [JsonInclude]
    public int AmmoStack { get; set; }
}