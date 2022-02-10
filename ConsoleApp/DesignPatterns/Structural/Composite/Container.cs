using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Composite
{
    public class Container : Item
    {
        public readonly ICollection<Item> _content;

        public Container(string name) : base(name)
        {
            _content = new List<Item>();
        }

        public override float GetPrice()
        {
            var sum = _content.Sum(x => x.GetPrice());
            Console.WriteLine($"Warość {Name}: {sum}");
            return sum;
        }

        public virtual void Add(Item item)
        {
            _content.Add(item);
        }
    }
}
