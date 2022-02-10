using ConsoleApp.SOLID.L2;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignPatterns.Structural.Flyweight.Client.Execute();

            //Rectangle rectangle = new Square();
            //ShowArea(rectangle, 3, 5);

        }

        static void ShowArea(Rectangle rectangle, int a, int b)
        {
            rectangle.A = a;
            rectangle.B = b;
            Console.WriteLine($"Pole prostokąta o bokach {a} i {b} jest równe {rectangle.Area}");
        }
    }
}
