using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Screens
{
    public class Configuration
    {
        public static string FileName = "Config.json";
        public Rectangle Healing { get; set; }
        public Rectangle Amulet { get; set; }
        public Rectangle Ring { get; set; }


        public static Configuration FromFile()
        {
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName)))
                return new Configuration();

            
            var archive = File.ReadAllText(FileName);

            try
            {
                return JsonSerializer.Deserialize<Configuration>(archive);
            }
            catch
            {
                return new Configuration();
            }

        }
        public void ToFile()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);

            File.WriteAllText(path, JsonSerializer.Serialize(this, new JsonSerializerOptions{
                WriteIndented = true
            }));
        }
    }

}
