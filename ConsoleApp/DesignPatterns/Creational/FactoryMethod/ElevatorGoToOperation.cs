using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod
{
    public class ElevatorGoToOperation : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Winda rusza na piętro {floor}");
        }
    }
}
