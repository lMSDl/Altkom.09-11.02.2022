using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Composite
{
    public class Product : Item, ICloneable
    {
        public float Price { get; set; }
        public Product(string name, float price) : base(name)
        {
            Price = price;
        }

        public override float GetPrice()
        {
            Console.WriteLine($"Wartość {Name}: {Price}");
            return Price;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
