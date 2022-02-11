using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.State
{
    public class CoffeeMachine
    {
        private State _state = null;

        public CoffeeMachine()
        {
            TransitionTo(new HeatingUpState());
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"CoffeeMachine: Transition to {state.GetType().Name}.");
            _state = state;
            _state.CoffeeMachine = this;
        }

        public void SmallCoffee()
        {
            _state.SmallCoffee();
        }

        public void LargeCoffee()
        {
            _state.LargeCoffee();
        }
    }
}
