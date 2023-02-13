using LacationGatherer.Server.Data;
using LacationGatherer.Server.Persistence.Repositories.Abstractions;
using LacationGatherer.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace LacationGatherer.Server.Persistence.Repositories.Implementations
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DbSet<Person> _people;
        public PersonRepository(DataContext context)
        {
            _people = context.Set<Person>();
        }

        public async Task Add(Person person)
        {
            _people.Add(person);
        }

        public async Task<List<Person>> GetAll()
        {
            return _people.ToList();
        }
    }
}
