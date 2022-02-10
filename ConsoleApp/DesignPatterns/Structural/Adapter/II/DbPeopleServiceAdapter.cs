using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Adapter.II
{
    public class DbPeopleServiceAdapter : IPeopleService
    {
        private DbPeopleService _service;
        public DbPeopleServiceAdapter(DbPeopleService service)
        {
            _service = service;
        }

        public IEnumerable<IPerson> Get()
        {
            var people = _service.Get();

            return people.Select(x => new DbPersonAdapter(x));
        }

        public IEnumerable<Person> GetPeople()
        {
            var people = _service.Get();

            return people.Select(x => new Person { Name = $"{x.FirstName} {x.LastName}", Age = DateTime.Today.Year - x.BirthDate.Year });
        }
    }
}
