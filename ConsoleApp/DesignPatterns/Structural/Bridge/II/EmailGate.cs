using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Bridge.II
{
    public class EmailGate : IMessageImplementation
    {
        public string PrepareMessage(string message)
        {
            return $"Wiadomość została wysłana przez email: {message}";
        }

        public void SendMessage(string message)
        {
                Console.WriteLine(message);
        }
    }
}
