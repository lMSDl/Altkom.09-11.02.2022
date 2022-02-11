using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.State
{
    public class Client
    {
        public static void Execute()
        {
            var coffeeMachine = new CoffeeMachine();
            Task.Delay(TimeSpan.FromSeconds(2)).ContinueWith(x => coffeeMachine.LargeCoffee());

            Task.Delay(TimeSpan.FromSeconds(7)).ContinueWith(x => coffeeMachine.LargeCoffee());

            Task.Delay(TimeSpan.FromSeconds(10)).ContinueWith(x => coffeeMachine.SmallCoffee());
            Task.Delay(TimeSpan.FromSeconds(11)).ContinueWith(x => coffeeMachine.SmallCoffee());

            Console.ReadKey();
        }
    }
}