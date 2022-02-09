using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod
{
    public class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var action = "Down";
            var floor = 3;
            elevator.Execute(action, floor);
            elevator.Execute("GoTo", 5);
            elevator.Execute(action, floor);
        }

        //private static void Click(Elevator elevator, string action, int floor)
        //{
        //    IElevatorOperation elevatorOperation = null;
        //    switch (action)
        //    {
        //        case "Down":
        //            elevatorOperation = new ElevatorDownOperation();
        //            break;
        //        case "Up":
        //            elevatorOperation = new ElevatorUpOperation();
        //            break;
        //    }

        //    if (elevatorOperation != null)
        //    {
        //        elevator.Execute(elevatorOperation, floor);
        //    }
        //}
    }
}
