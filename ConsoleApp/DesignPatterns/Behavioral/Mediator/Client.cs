using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Mediator
{
    public class Client
    {
        public static void Execute()
        {
            var chat = new Chat();

            ChatMember user = new ChatUser("Paul");
            ChatMember bot1 = new EchoBot("Bot1");
            ChatMember bot2 = new EchoBot("Bot2");

            chat.Join(user);
            chat.Join(bot1);
            chat.Join(bot2);

            user.Send("Bot1", "Hello!");
            user.Send("Bot2", "Hi!");
            user.Send("Bot3", "Bye!");

            user.Send("Hello all!");

        }
        }
}
