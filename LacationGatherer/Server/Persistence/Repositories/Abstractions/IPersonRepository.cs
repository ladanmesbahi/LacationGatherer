using LacationGatherer.Shared.Models;

namespace LacationGatherer.Server.Persistence.Repositories.Abstractions
{
    public interface IPersonRepository
    {
        Task Add(Person person);
        Task<List<Person>> GetAll();
    }
}
