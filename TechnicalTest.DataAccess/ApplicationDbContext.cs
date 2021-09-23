using Microsoft.EntityFrameworkCore;
using TechnicalTest.DataAccess.Models;

namespace TechnicalTest.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
               
        }

        DbSet<Address> Addresses { set; get; }
        DbSet<Organization> Organizations { set; get; }
        DbSet<Person> Persons { set; get; }
    }
}
