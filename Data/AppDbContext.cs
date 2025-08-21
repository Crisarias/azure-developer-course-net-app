using Microsoft.EntityFrameworkCore;

namespace azure_app_cariasc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

       // Example DbSet property
       public DbSet<Person> Persons { get; set; }
    }

}