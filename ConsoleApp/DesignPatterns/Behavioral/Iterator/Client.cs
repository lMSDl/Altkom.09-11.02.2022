using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Iterator
{
    public class Client
    {
        public static void Execute()
        {
            var list = new List<string>() { "a", "b", "c" };

            var temp = list.FirstOrDefault();
            for (int i = 1; i < list.Count; i++)
            {
                Console.WriteLine(temp + " " + list[i]);
                temp = list[i];
            }

            var buffer = new Buffer<string>(list);
            foreach (var item in buffer)
            {
                Console.WriteLine(item[0] + " " + item[1]);
            }
        }
    }
}
