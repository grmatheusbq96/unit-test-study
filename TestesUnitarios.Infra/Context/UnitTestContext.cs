using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace TestesUnitarios.Infra.Context
{
    public class UnitTestContext : DbContext
    {
        public UnitTestContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UnitTest;Integrated Security=True;Connect Timeout=30");
        }
    }
}