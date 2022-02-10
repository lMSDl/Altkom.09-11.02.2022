using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.PrivateClassData
{
    class PrivateData
    {
        private int _a;
        private string _b;

        public PrivateData(int a, string b)
        {
            _a = a;
            _b = b;
        }

        public int GetA()
        {
            return _a;
        }

        public string GetB()
        {
            return _b;
        }
    }
}
