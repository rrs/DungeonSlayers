using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace DungeonSlayers
{
    public class Helper
    {
        public static void LoadTraits()
        {
            var yaml = File.ReadAllText(".\\traits.yaml");
            var deserializer = new DeserializerBuilder()
    .WithNamingConvention(CamelCaseNamingConvention.Instance)
    .Build();
            var traits = deserializer.Deserialize<YamlTraits>(yaml);

        }
    }
}
