using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Proxy
{
    public class DatabaseProxy : IDatabase
    {
        private IDatabase database;
        private const int InitialCount = 3;
        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(InitialCount);
        private Type databaseType;

        public DatabaseProxy(IDatabase database)
        {
            databaseType = database.GetType();
            this.database = database;
        }

        public async Task<int?> RequestAsync(int parameter)
        {
            if(database == null)
            {
                Console.WriteLine("Otwieranie połączenia z bazą danych");
                database = (IDatabase)Activator.CreateInstance(databaseType);
            }

            await semaphoreSlim.WaitAsync();

            var result = await database.RequestAsync(parameter);

            semaphoreSlim.Release();

            if(semaphoreSlim.CurrentCount == InitialCount)
            {
                Console.WriteLine("Zamykanie połączenia z bazą danych");
                database = null;
            }

            return result;
        }
    }
}
