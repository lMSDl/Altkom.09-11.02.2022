using System;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.State
{
    internal class HeatingUpState : State
    {
        public HeatingUpState()
        {
            var task = Task.Delay(TimeSpan.FromSeconds(5));
            task.ContinueWith(x => CoffeeMachine.TransitionTo(new IdleState()));
        }

        public override void LargeCoffee()
        {
            Console.WriteLine("HeatingUpState: i am heating up");
        }

        public override void SmallCoffee()
        {
            Console.WriteLine("HeatingUpState: i am heating up");
        }
    }
}