using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Strategy
{
    public class Calculator
    {
        public ICalcStrategy Strategy { get; set; }

        public float? Operate(float val1, float val2)
        {
            return Strategy?.Calculate(val1, val2);
        }
    }
}
