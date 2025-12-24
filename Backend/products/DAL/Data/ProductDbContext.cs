using Microsoft.EntityFrameworkCore;
using products.Entities;
namespace products.DAL.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; } = null;
    }
}
