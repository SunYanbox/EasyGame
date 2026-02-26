using System.Text.Json.Serialization;

namespace EasyGame.Configs;

// 模组配置
internal record StimulatorConfig
{
    [JsonInclude] public int UseTimes {get; set;}
    [JsonInclude] public double PriceModify {get; set;}
    [JsonInclude] public double Weight {get; set;}
}