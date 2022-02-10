using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Facade.I
{
    public class Client
    {

        public static void Execute()
        {
            var person = new Person() { Name = "Ewa Ewowska", BirthDate = DateTime.Now };

            var json = JsonConvertFacade.Serialize(person);

            Console.WriteLine(json);
        }
    }
}
