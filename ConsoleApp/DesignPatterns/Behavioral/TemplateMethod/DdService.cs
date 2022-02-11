using System;

namespace ConsoleApp.DesignPatterns.Behavioral.TemplateMethod
{
    public class DbService : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Zamknięcie połączenia z bazą danych");
        }

        internal void Create(LogEntity info)
        {
            Console.WriteLine("Zapis do bazy danych");
        }
    }
}