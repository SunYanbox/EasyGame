using System;
using System.Text.Json;

using EasyGame.Configs;

using JetBrains.Annotations;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EasyGame.Tests.Configs;

[TestClass]
[TestSubject(typeof(ModConfigData))]
public class ModConfigDataTest
{

    [TestMethod]
    public void Method()
    {
        Console.WriteLine(JsonSerializer.Serialize(new ModConfigData()));
    }
}