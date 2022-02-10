using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Adapter.II
{
    public class DbPersonAdapter : IPerson
    {
        private DbPerson person;

        public DbPersonAdapter(DbPerson person)
        {
            this.person = person;
        }

        public string Name => $"{person.FirstName} {person.LastName}";

        public int Age => DateTime.Today.Year - person.BirthDate.Year;
    }
}
