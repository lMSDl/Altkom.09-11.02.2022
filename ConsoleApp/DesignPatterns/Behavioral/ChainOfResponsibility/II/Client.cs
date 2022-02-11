using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class Client
    {
        public static void Execute()
        {
            var button = new Button();

            button.Func = x =>
            {
                var parent = (TextBox)x;
                
                if(string.IsNullOrEmpty(parent.InputText))
                    return false;

                parent.InputText = null;
                Console.WriteLine("TextBox clear");
                return true;
            };

            var textBox = new TextBox();
            textBox.Add(button);

            var frame = new Frame();
            frame.Add(textBox);


            button.Click();

            textBox.InputText = Console.ReadLine();

            button.Click();

            textBox.Click();

            frame.Click();

        }
        }
}
