using Dot_Net_Ecom.Models;
using Microsoft.EntityFrameworkCore;

namespace Dot_Net_Ecom.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
