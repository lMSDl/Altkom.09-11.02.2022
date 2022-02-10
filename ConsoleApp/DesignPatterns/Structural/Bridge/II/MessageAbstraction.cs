using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Bridge.II
{
    public class MessageAbstraction
    {
        public IMessageImplementation MessageImplementation { get; }

        public MessageAbstraction(IMessageImplementation messageImplementation)
        {
            MessageImplementation = messageImplementation;
        }

        public virtual void Send(string message)
        {
            message = MessageImplementation.PrepareMessage(message);
            MessageImplementation.SendMessage(message);
        }
    }
}
