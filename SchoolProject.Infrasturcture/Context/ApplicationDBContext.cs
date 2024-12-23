using Microsoft.EntityFrameworkCore;
using RentSystem.Infrasturcture.Entities;

namespace RentSystem.Infrasturcture.Data
{
    public class ApplicationDBContext : DbContext
    {
       
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Owner> Owners { get; set; }
   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
