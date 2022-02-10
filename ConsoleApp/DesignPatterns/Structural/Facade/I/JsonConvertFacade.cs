using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Facade.I
{
    public static class JsonConvertFacade
    {
       private static JsonSerializerSettings Settings { get; } = new JsonSerializerSettings
       {
           Formatting = Formatting.Indented,
           DateFormatString = "MM-dd yyyy",
           DefaultValueHandling = DefaultValueHandling.Ignore
       };

        public static string Serialize<T>(T item)
        {
            return JsonConvert.SerializeObject(item, Settings);
        }
        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, Settings);
        }
    }
}
