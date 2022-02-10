using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Decorator
{
    public class Client
    {
        public static void Execute()
        {
            var test = Console.ReadLine();

            INotification notification = new Notification();
            Console.WriteLine("SMS?");
            if (Console.ReadKey().KeyChar == 'y')
            {
                Console.WriteLine();
                notification = new SmsNotificationDecorator(notification);
            }
            Console.WriteLine();
            Console.WriteLine("Email?");
            Console.WriteLine();
            if (Console.ReadKey().KeyChar == 'y')
            {
                Console.WriteLine();
                notification = new EmailNotificationDecorator(notification);
            }

            #region DO NOT TOUCH!
            notification.Send(test);
            #endregion
        }
    }
}
