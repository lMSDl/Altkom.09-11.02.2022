using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Composite
{
    public abstract class Item
    {
        public string Name { get; }

        protected Item(string name)
        {
            Name = name;
        }

        public abstract float GetPrice();
    }
}
