using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Memento
{
    public class Person : ICloneable, IRestorable<Person>
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }


        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Restore(Person state)
        {
            GetType().GetProperties().Where(x => x.CanWrite && x.CanRead)
                .ToList().ForEach(x => x.SetValue(this, x.GetValue(state)));
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
