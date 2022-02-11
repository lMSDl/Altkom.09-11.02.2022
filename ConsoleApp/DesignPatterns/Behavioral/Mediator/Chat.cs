using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Mediator
{
    public class Chat : IChatMediator
    {
        private ICollection<ChatMember> chatMembers = new List<ChatMember>();

        public void Join(ChatMember chatMember)
        {
            chatMembers.Add(chatMember);
            chatMember.Chat = this;
        }
        public void Quit(ChatMember chatMember)
        {
            chatMembers.Remove(chatMember);
            if(chatMember.Chat == this)
                chatMember.Chat = null;
        }

        public void Send(string from, string message)
        {
            var query = chatMembers.Where(x => x.Nick != from);

            var sender = chatMembers.SingleOrDefault(x => x.Nick == from);
            if(sender is EchoBot)
            {
                query = query.Where(x => !(x is EchoBot));
            }

            foreach (var item in query)
            {
                item.Receive(from, message, false);
            }
        }

        public void Send(string from, string to, string message)
        {
            chatMembers.SingleOrDefault(x => x.Nick == to)?.Receive(from, message, true);
        }
    }
}
