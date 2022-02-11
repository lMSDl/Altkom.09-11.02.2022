using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.State
{
    internal class WorkingState : State
    {
        private readonly CancellationTokenSource _cancellationTokenSource;
        public WorkingState(int duration)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            var task = Task.Delay(TimeSpan.FromSeconds(duration), _cancellationTokenSource.Token);
            task.ContinueWith(x => { CoffeeMachine.TransitionTo(new IdleState()); _cancellationTokenSource.Dispose(); });
        }

        public override void LargeCoffee()
        {
            _cancellationTokenSource.Cancel();
            Console.WriteLine("WorkingState: process cancelled");
        }

        public override void SmallCoffee()
        {
            _cancellationTokenSource.Cancel();
            Console.WriteLine("WorkingState: process cancelled");
        }
    }
}