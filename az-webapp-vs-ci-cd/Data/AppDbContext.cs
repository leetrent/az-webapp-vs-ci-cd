using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace az_webapp_vs_ci_cd.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}
