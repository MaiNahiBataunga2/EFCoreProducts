using EFCoreProduct.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreProduct
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }

        public DbSet<Product> products { get; set; }
    }
}
