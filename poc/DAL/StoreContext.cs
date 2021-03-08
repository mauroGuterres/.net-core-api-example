using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using poc.Model;



namespace poc.DAL
{
    public class StoreContext : DbContext
    {
        
        public StoreContext([NotNullAttribute] DbContextOptions<StoreContext> options) : base(options)
        {

        }

        public DbSet<Funcionario> Funcionarios {get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
               builder.Entity<Funcionario>().HasKey(m => m.Id);               
               base.OnModelCreating(builder);
        }

    }
}