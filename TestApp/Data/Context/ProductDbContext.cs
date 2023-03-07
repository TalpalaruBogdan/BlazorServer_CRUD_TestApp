using Microsoft.EntityFrameworkCore;
using TestApp.Data.Models;

namespace TestApp.Data.Context
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> opt) : base(opt)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
