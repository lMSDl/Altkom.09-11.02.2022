using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public class Client
    {
        public static void Execute()
        {
            //var handler5 = new DiscountHandler("Kierownik Sklepu", 500, 4500);
            //var handler4 = new DiscountHandler("Kierownik Hali", 500, 5000, handler5);
            var handler3 = new DiscountHandler("Manager Kas", 200, 8000);
            var handler2 = new DiscountHandler("Super Kasjer", 100, 8000, handler3);
            var handler1 = new DiscountHandler("Kasjer", 100, 10000, handler2);


            Console.WriteLine(handler1.Discount(250, 8000));
            Console.WriteLine(handler1.Discount(1000, 8000));
            Console.WriteLine(handler3.Discount(300, 10000));
        }
    }
}