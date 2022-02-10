using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Bridge.II
{
    public interface IMessageImplementation
    {
        string PrepareMessage(string message);

        void SendMessage(string message);
    }
}
