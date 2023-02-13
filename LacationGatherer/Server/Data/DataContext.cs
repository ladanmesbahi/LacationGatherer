using LacationGatherer.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace LacationGatherer.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Person> People { get; set; }
    }
}
