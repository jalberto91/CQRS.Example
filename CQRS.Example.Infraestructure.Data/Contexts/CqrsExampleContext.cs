using CQRS.Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Example.Infraestructure.Data.Contexts
{
    public class CqrsExampleContext : DbContext
    {
        #region Constructor

        public CqrsExampleContext()
        {
        }

        public CqrsExampleContext(DbContextOptions<CqrsExampleContext> options) : base(options)
        {
        }

        #endregion Constructor

        #region DbSets

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Student> Students { get; set; }

        #endregion DbSets
    }
}