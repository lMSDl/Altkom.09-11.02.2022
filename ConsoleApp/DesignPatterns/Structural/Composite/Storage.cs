using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Composite
{
    public class Storage : Container
    {
        public Storage(string name) : base(name)
        {
        }

        public override void Add(Item item)
        {
            if (item is Container)
                base.Add(item);
            else
                throw new Exception();
        }
    }
}
