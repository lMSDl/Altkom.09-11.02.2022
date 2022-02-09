using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.Prototype
{
    public class Person : ICloneable
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<string> Addresses { get; set; }
        public IdInfo IdInfo { get; set; }

        public object Clone()
        {
            var person = (Person)MemberwiseClone();
            person.Addresses = Addresses.ToList(); //new List<string>(Addresses);
            person.IdInfo = (IdInfo)IdInfo.Clone();
            return person;
        }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }
    }
}
