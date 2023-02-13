namespace LacationGatherer.Server.Persistence.UnitOfWorks.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        Task Complete();
    }
}
