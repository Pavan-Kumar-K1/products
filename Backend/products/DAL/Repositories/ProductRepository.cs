using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using products.DAL.Data;
using products.Entities;

namespace products.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        protected readonly ProductDbContext _context;
        protected readonly DbSet<Product> _products;

        public ProductRepository(ProductDbContext context)
        {
            _context = context;
            _products = _context.Set<Product>();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _products.ToListAsync();
        }
    }
}
