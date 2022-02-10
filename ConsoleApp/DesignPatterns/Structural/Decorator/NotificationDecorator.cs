using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Decorator
{
    public abstract class NotificationDecorator : INotification
    {
        private INotification notification;

        public NotificationDecorator(INotification notification)
        {
            this.notification = notification;
        }

        public void Send(string message)
        {
            notification.Send(message);
            ExtraSend(message);
        }

        protected abstract void ExtraSend(string message);
    }
}
