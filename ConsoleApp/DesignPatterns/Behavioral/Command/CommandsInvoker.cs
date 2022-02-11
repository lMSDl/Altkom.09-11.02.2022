using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Command
{
    public class CommandsInvoker
    {
        private static readonly ICollection<ICommand> Commands = new List<ICommand>();
        private ICommand _command;

        public CommandsInvoker(ICommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            if(_command.Execute())
                Commands.Add(_command);
        }

        public static void Undo()
        {
            var lastCommand = Commands.LastOrDefault();
            if(lastCommand != null)
            {
                Commands.Remove(lastCommand);
                lastCommand.Undo();
            }    
        }
    }
}
