using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Bridge.II
{
    public static class Client
    {
        public static void Execute()
        {
            var message = new MessageAbstraction(new EmailGate());
            message.Send(Console.ReadLine());
            message = new MessageAbstraction(new SmsGate());
            message.Send(Console.ReadLine());
            message = new ShortMessageAbstraction(new SmsGate());
            message.Send(Console.ReadLine());
        }
    }
}
