using LacationGatherer.Server.Data;
using LacationGatherer.Server.Persistence.Repositories.Abstractions;
using LacationGatherer.Server.Persistence.Repositories.Implementations;
using LacationGatherer.Server.Persistence.UnitOfWorks.Abstractions;

namespace LacationGatherer.Server.Persistence.UnitOfWorks.Implementations
{
    public class PersonUnitOfWork : UnitOfWork, IPersonUnitOfWork
    {
        public PersonUnitOfWork(DataContext context) : base(context)
        {
            People = new PersonRepository(context);
        }

        public IPersonRepository People { get; }
    }
}
