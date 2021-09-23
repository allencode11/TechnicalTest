using Microsoft.EntityFrameworkCore;
using TechnicalTest.DataAccess.Models;

namespace TechnicalTest.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
               
        }

        public DbSet<Address> Addresses { set; get; }
        public DbSet<Organization> Organizations { set; get; }
        public DbSet<Person> Persons { set; get; }
        public DbSet<Registration> Registrations { set; get; }
    }
}
