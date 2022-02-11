using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Mediator
{
    public abstract class ChatMember
    {
        public string Nick { get; }

        public ChatMember(string nick)
        {
            Nick = nick;
        }

        public IChatMediator Chat { get; set; }

        public virtual void Send(string message)
        {
            Chat.Send(Nick, message);
        }

        public virtual void Send(string to, string message)
        {
            Chat.Send(Nick, to, message);
        }

        public abstract void Receive(string from, string message, bool isPrivate);
    }
}
