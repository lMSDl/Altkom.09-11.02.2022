using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Memento
{
    public class Client
    {
        public static void Execute()
        {

            var person = new Person();
            person.Name = "Adam Adamski";
            person.BirthDate = new DateTime(1992, 1, 23);

            var caretaker = new Caretaker<Person>(person);

            Console.WriteLine($"Name: {person.Name}");
            caretaker.SaveState();
            Thread.Sleep(2000);

            person.Name = "Ala";
            Console.WriteLine($"Name: {person.Name}");
            caretaker.SaveState();
            Thread.Sleep(2000);

            person.Name = "Ala Alowska";
            Console.WriteLine($"Name: {person.Name}");
            caretaker.SaveState();
            Thread.Sleep(2000);

            person.Name = "Ala Alowska 2";
            Console.WriteLine($"Name: {person.Name}");

            caretaker.ShowHistory();

            caretaker.Restore(DateTime.Now.AddSeconds(-4));
            Console.WriteLine($"Name: {person.Name}");

            caretaker.Undo();
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Undo();
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Undo();
            Console.WriteLine($"Name: {person.Name}");
            caretaker.ShowHistory();
        }
        }
}
