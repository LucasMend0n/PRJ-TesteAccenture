using CrudCompanies.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudCompanies.Context
{
    class CompaniesContext : DbContext
    {
        DbSet<Company> Companies { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
        public CompaniesContext(DbContextOptions<CompaniesContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}