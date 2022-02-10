using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Decorator
{
    public class SmsNotificationDecorator : NotificationDecorator
    {
        public SmsNotificationDecorator(INotification notification) : base(notification)
        {
        }

        protected override void ExtraSend(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }
}
