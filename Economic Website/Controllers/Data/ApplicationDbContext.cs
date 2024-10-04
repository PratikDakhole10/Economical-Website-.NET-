using Microsoft.EntityFrameworkCore;
namespace Economic_Website.Controllers.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
    }
}
