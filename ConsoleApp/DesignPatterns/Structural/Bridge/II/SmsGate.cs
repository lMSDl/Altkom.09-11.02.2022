using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Bridge.II
{
    public class SmsGate : IMessageImplementation
    {
        public const int MaxLength = 10;
        public string PrepareMessage(string message)
        {
            return $"Wiadomość została wysłana przez bramkę SMS: {message}";
        }

        public void SendMessage(string message)
        {
            foreach (var item in Enumerable.Range(0, (int)Math.Ceiling((float)message.Length / MaxLength))
                .Select(x => message.Substring(x * MaxLength, Math.Min(MaxLength, message.Length - x * MaxLength))))
            {
                Console.WriteLine(item);
            }
        }
    }
}
