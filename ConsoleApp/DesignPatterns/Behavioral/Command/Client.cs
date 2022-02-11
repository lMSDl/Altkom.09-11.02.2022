using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Command
{
    public class Client
    {
        public static void Execute()
        {
            var garden = new Garden(10);
            var command1 = new GardenCommand(garden, GardenAction.Plant, "drzewo");
            var command2 = new GardenCommand(garden, GardenAction.Remove, "drzewo");
            var command3 = new GardenCommand(garden, GardenAction.Plant, "kwiaty");
            var command4 = new GardenCommand(garden, GardenAction.Remove, "kwiaty");

            var plantTreeButton = new CommandsInvoker(command1);
            var removeTreeButton = new CommandsInvoker(command2);
            var plantFlowersButton = new CommandsInvoker(command3);
            var removeFlowersButton = new CommandsInvoker(command4);

            Console.WriteLine(garden);

            plantTreeButton.Invoke();
            plantTreeButton.Invoke();
            plantFlowersButton.Invoke();

            Console.WriteLine(garden);

            removeFlowersButton.Invoke();
            removeFlowersButton.Invoke();

            Console.WriteLine(garden);

            CommandsInvoker.Undo();
            CommandsInvoker.Undo();
            CommandsInvoker.Undo();
            CommandsInvoker.Undo();

            Console.WriteLine(garden);
        }
        }
}
