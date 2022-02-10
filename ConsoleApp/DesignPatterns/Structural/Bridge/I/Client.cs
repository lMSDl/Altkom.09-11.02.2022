using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Bridge
{
    class Client
    {
        public static void Execute()
        {
            Shape shape = new Circle();
            Console.WriteLine(shape);

            shape.Color = new Red();
            Console.WriteLine(shape);

        }
    }
}
