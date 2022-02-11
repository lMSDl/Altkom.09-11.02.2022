using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Command
{
    public class Garden
    {
        public int Size { get; set; }
        private List<string> Plants { get; } = new List<string>();

        public Garden(int size)
        {
            Size = size;
        }

        public bool Plant(string name)
        {
            if(Plants.Count < Size)
            {
                Plants.Add(name);
                Console.WriteLine($"{name} został(a) zasadzona");
                return true;
            }

            Console.WriteLine($"Brak miejsca w ogrodzie na {name}");
            return false;
        }

        public bool Remove(string name)
        {
            if(Plants.Any(x => x == name))
            {
                Plants.Remove(name);
                Console.WriteLine($"{name} został(a) usunięta");
                return true;
            }

            Console.WriteLine($"W ogrodzie nie ma {name}");
            return false;
        }

        public override string ToString()
        {
            return string.Join("\n", Plants);
        }
    }
}
