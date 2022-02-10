using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.PrivateClassData
{
    public class Data
    {
        private PrivateData _privateData;

        public Data(int a, string b)
        {
            _privateData = new PrivateData(a, b);
        }

        public void SomeFunction()
        {
            _privateData.GetA();
        }
    }
}
