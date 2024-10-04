using Economic_Website.Models;
using Microsoft.EntityFrameworkCore;
namespace Economic_Website.Controllers.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                  new Category { Id = 1,Name = "Action", DisplayOrders = 1 },
                  new Category { Id = 2, Name = "Scifi", DisplayOrders = 2 },
                  new Category { Id = 3, Name = "History", DisplayOrders = 3 }
                );
        }
    }
}
