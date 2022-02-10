using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Adapter.II
{
    public class Client
    {
        public static void Execute()
        {
            IPeopleService service = new DbPeopleServiceAdapter(new DbPeopleService());

            foreach (var item in service.Get())
            {
                Show(item);
            }

        }

        static void Show(IPerson person)
        {
            Console.WriteLine(JsonConvert.SerializeObject(person, Formatting.Indented));
        }
    }
}
