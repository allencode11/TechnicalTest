using Microsoft.EntityFrameworkCore;
using System;

namespace TechnicalTest.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
               
        }

    }
}
