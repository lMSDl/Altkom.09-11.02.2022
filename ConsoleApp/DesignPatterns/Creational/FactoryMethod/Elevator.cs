using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod
{
    public class Elevator
    {
        private readonly Dictionary<string, IElevatorOperation> _operations = new Dictionary<string, IElevatorOperation>();

        public void Execute(string action, int floor)
        {
            CreateOperation(action)?.Operate(floor);
        }
        public void Execute(IElevatorOperation operation, int floor)
        {
            operation?.Operate(floor);
        }


        public IElevatorOperation CreateOperation(string action)
        {
            if (_operations.TryGetValue(action, out var result))
                return result;

            result = (IElevatorOperation)Activator.CreateInstance(
            AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => !x.IsInterface)
                .Where(x => typeof(IElevatorOperation).IsAssignableFrom(x))
                .Single(x => x.Name.Contains(action))
                );


            //switch (action)
            //{
            //    case "Down":
            //        result = new ElevatorDownOperation();
            //        break;
            //    case "Up":
            //        result = new ElevatorUpOperation();
            //        break;
            //    case "GoTo":
            //        result = new ElevatorGoToOperation();
            //        break;
            //}
            if (result != null)
                _operations[action] = result;

            return result;
        }
    }
}
