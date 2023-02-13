using LacationGatherer.Server.Persistence.Repositories.Abstractions;

namespace LacationGatherer.Server.Persistence.UnitOfWorks.Abstractions
{
    public interface IPersonUnitOfWork : IUnitOfWork
    {
        IPersonRepository People { get; }
    }
}
