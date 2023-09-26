using System;
using Microsoft.EntityFrameworkCore;
using MODEL.Entities;
namespace REPOSITORY
{
	public class DataContext: DbContext
	{
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost;Database=dotnet-bank;User ID=SA;Password=Yourgod10;Encrypt=True;TrustServerCertificate=True;Integrated Security=False;Connection Timeout=60");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
	}
}

