﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.SOLID.D
{
    interface IMessage
    {
        void Send();
    }

    class SMS : IMessage
    {
        public string Number { get; set; }
        public string Content { get; set; }

        public void Send()
        {
            SendSMS();
        }

        public void SendSMS()
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    class MMS : IMessage
    {
        public string Number { get; set; }
        public byte[] Content { get; set; }

        public void Send()
        {
            SendMMS();
        }
        public void SendMMS()
        {
            Console.WriteLine("Sending MMS...");
        }
    }

    class Mail : IMessage
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void Send()
        {
            SendMail();
        }
        public void SendMail()
        {
            Console.WriteLine("Sending Mail...");
        }
    }

    class Messenger
    {
        public IEnumerable<IMessage> Messages { get; set; }

        public Messenger(IEnumerable<IMessage> messages)
        {
            Messages = messages;
        }

        public void SendMessage(IEnumerable<IMessage> messages)
        {
            foreach (var item in messages)
            {
                item.Send();
            }
        }

            public void SendMessage()
        {
            SendMessage(Messages);
        }
    }
}
