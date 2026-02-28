using SPTarkov.Server.Core.Models.Spt.Mod;
using Range = SemanticVersioning.Range;

namespace EasyGame;

public record ModMetadata : AbstractModMetadata
{
    public override string ModGuid { get; init; } = "com.suntion.easygame";
    public override string Name { get; init; } = "EasyGame";
    public override string Author { get; init; } = "Suntion";
    public override List<string>? Contributors { get; init; } = [];
    public override SemanticVersioning.Version Version { get; init; } = new("1.1.0");
    public override Range SptVersion { get; init; } = new("~4.0.4");
    
    public override List<string>? Incompatibilities { get; init; }

    public override Dictionary<string, Range>? ModDependencies { get; init; } =
        new()
        {
            { "com.suntion.suntioncore", new Range(">=1.0.0") }
        };
    public override string? Url { get; init; } = "https://github.com/SunYanbox/SPTEasyGame";
    public override bool? IsBundleMod { get; init; } = false;
    public override string? License { get; init; } = "CC-BY-SA";
}