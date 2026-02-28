### Configuration File

```json
{
    // Function enable/disable switches
    "EnableFunction": {
        // Whether to remove all flea market selling restrictions on items
        "IsUnlockAllItemsSellLimit": true,
        // Whether to display Labyrinth map in map selection screen
        "ShowMapToChoiceScene": true,
        // Whether to customize item carry limits into raid
        "EnterGameItemLimit": true,
        // Whether to modify health, energy and hydration values
        "EnergyHydrationModify": true,
        // Whether to modify raid duration
        "RaidTimeModify": true,
        // Whether to modify magazine loading/unloading/checking times
        "AmmoTimeModify": true,
        // Whether to modify flea market max active offer count per level
        "MaxActiveOfferCountModify": true,
        // Whether to adjust Labs access card usage count
        "AdjustLabsAccess": true,
        // Whether to adjust Labyrinth access card usage count
        "AdjustLabysAccess": true,
        // Whether to modify stimulator durability (excluding morphine)
        "AdjustSimulatorMaxHpResource": true,
        // Whether to adjust ammo stack size
        "AdjustAmmoStack": true,
        // Whether to set all items as examined by default
        "AllExaminedByDefault": false
    },
    // Stimulator configuration settings
    "StimulatorConfig": {
        // Number of uses for stimulators
        "UseTimes": 10,
        // Price multiplier for stimulators
        "PriceModify": 5,
        // Weight of stimulators in kilograms
        "Weight": 0.5
    },
    // Maximum item limit when entering raid
    "EnterGameItemLimit": 3600,
    // Health multiplier for all profiles
    "HealthModify": 1.5,
    // Energy and hydration multiplier for all profiles
    "EnergyHydrationModify": 1.5,
    // Raid duration multiplier
    "RaidTimeModify": 3,
    // Magazine loading time multiplier
    "TakeInAmmoTimeModify": 0.05,
    // Magazine unloading time multiplier
    "TakeOutAmmoTimeModify": 0.05,
    // Magazine checking time multiplier
    "CheckAmmoTimeModify": 0.45,
    // Flea market max active offers multiplier per level
    "MaxActiveOfferCountModify": 7,
    // Labs access card maximum usage count
    "LabsAccessMaximumNumberOfUsage": 10,
    // Labyrinth access card maximum usage count
    "LabysAccessMaximumNumberOfUsage": 10,
    // Ammo stack size
    "AmmoStack": 300
}
```

### 配置文件

```json
{
    // 功能开关配置
    "EnableFunction": {
        // 是否解除所有物品在跳蚤市场的售卖限制
        "IsUnlockAllItemsSellLimit": true,
        // 是否在地图选择界面显示迷宫地图
        "ShowMapToChoiceScene": true,
        // 是否自定义带入战局的物品数量限制
        "EnterGameItemLimit": true,
        // 是否修改角色的血量、能量和水分值
        "EnergyHydrationModify": true,
        // 是否修改战局持续时间
        "RaidTimeModify": true,
        // 是否修改弹匣装弹/卸弹/检查时间
        "AmmoTimeModify": true,
        // 是否修改每级跳蚤市场的最大挂单数量
        "MaxActiveOfferCountModify": true,
        // 是否调整实验室访问卡的使用次数
        "AdjustLabsAccess": true,
        // 是否调整迷宫访问卡的使用次数
        "AdjustLabysAccess": true,
        // 是否修改刺激剂（除吗啡外）的耐久度
        "AdjustSimulatorMaxHpResource": true,
        // 是否调整弹药的堆叠数量
        "AdjustAmmoStack": true,
        // 是否默认所有物品为已检视状态
        "AllExaminedByDefault": false
    },
    // 刺激剂配置参数
    "StimulatorConfig": {
        // 刺激剂可使用次数
        "UseTimes": 10,
        // 刺激剂价格倍率
        "PriceModify": 5,
        // 刺激剂重量（千克）
        "Weight": 0.5
    },
    // 进入战局时的物品数量限制
    "EnterGameItemLimit": 3600,
    // 所有存档角色的血量倍率
    "HealthModify": 1.5,
    // 所有存档角色的能量和水分倍率
    "EnergyHydrationModify": 1.5,
    // 战局持续时间倍率
    "RaidTimeModify": 3,
    // 装弹时间倍率
    "TakeInAmmoTimeModify": 0.05,
    // 卸弹时间倍率
    "TakeOutAmmoTimeModify": 0.05,
    // 检查弹匣时间倍率
    "CheckAmmoTimeModify": 0.45,
    // 每级跳蚤市场最大挂单数量倍率
    "MaxActiveOfferCountModify": 7,
    // 实验室访问卡最大使用次数
    "LabsAccessMaximumNumberOfUsage": 10,
    // 迷宫访问卡最大使用次数
    "LabysAccessMaximumNumberOfUsage": 10,
    // 弹药堆叠数量
    "AmmoStack": 300
}
```

### .user文件示例

```xml
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="Current" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <!--         Set YOUR OWN SPT path here -->
    <SPTPath>F:\EFT_SPT4_0\SPT\</SPTPath>
  </PropertyGroup>
</Project>
```

### launchSettings.json 文件示例

```json
{
  "profiles": {
    "SPTarkov.Server": {
      "commandName": "Executable",
      "executablePath": "F:\\EFT_SPT4_0\\SPT\\SPT.Server.exe",
      "commandLineArgs": "",
      "workingDirectory": "F:\\EFT_SPT4_0\\SPT",
      "environmentVariables": {
      }
    }
  }
}
```
