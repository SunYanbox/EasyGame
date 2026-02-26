using System.Text.Json.Serialization;

namespace EasyGame.Configs;

// 模组配置
internal record StimulatorConfig
{
    [JsonInclude] public int UseTimes { get; set; } = 10;
    [JsonInclude] public double PriceModify { get; set; } = 5;
    [JsonInclude] public double Weight { get; set; } = 0.5;
}