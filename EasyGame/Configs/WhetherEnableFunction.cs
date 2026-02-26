using System.Text.Json.Serialization;

namespace EasyGame.Configs;

record WhetherEnableFunction
{
    /// <summary> 是否解除所有物品在跳蚤市场售卖限制 </summary>
    [JsonInclude]
    public bool IsUnlockAllItemsSellLimit { get; set; } = true;

    /// <summary> 是否将迷宫地图显示于地图选择页面 </summary>
    [JsonInclude]
    public bool ShowMapToChoiceScene { get; set; } = true;

    /// <summary> 是否自定义带入物品限制 </summary>
    [JsonInclude]
    public bool EnterGameItemLimit { get; set; } = true;

    /// <summary> 是否修改血量与水分 </summary>
    [JsonInclude]
    public bool EnergyHydrationModify { get; set; } = true;

    /// <summary> 是否修改战局时长 </summary>
    [JsonInclude]
    public bool RaidTimeModify { get; set; } = true;

    /// <summary> 是否修改弹夹装单卸弹检查弹匣时间 </summary>
    [JsonInclude]
    public bool AmmoTimeModify { get; set; } = true;

    /// <summary> 是否修改每级跳蚤市场挂单上限倍率 </summary>
    [JsonInclude]
    public bool MaxActiveOfferCountModify { get; set; } = true;

    /// <summary> 是否调整实验室访问卡次数 </summary>
    [JsonInclude]
    public bool AdjustLabsAccess { get; set; } = true;

    /// <summary> 是否调整迷宫访问卡次数 </summary>
    [JsonInclude]
    public bool AdjustLabysAccess { get; set; } = true;

    /// <summary> 是否修改所有药剂耐久(吗啡除外) </summary>
    [JsonInclude]
    public bool AdjustSimulatorMaxHpResource { get; set; } = true;

    /// <summary> 是否调整弹药堆叠 </summary>
    [JsonInclude]
    public bool AdjustAmmoStack { get; set; } = true;

    /// <summary> 是否令所有物品默认已检视 </summary>
    [JsonInclude]
    public bool AllExaminedByDefault { get; set; } = true;
}