using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Mediator
{
    public interface IChatMediator
    {
        void Send(string from, string message);
        void Send(string from, string to, string message);
    }
}
