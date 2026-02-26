.user文件示例

```xml
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="Current" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <!--         Set YOUR OWN SPT path here -->
    <SPTPath>F:\EFT_SPT4_0\SPT\</SPTPath>
  </PropertyGroup>
</Project>
```

launchSettings.json 文件示例

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