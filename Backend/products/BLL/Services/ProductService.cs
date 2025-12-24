using products.DAL.Repositories;
using products.Entities;

namespace products.BLL.Services
{
    public class ProductService(IProductRepository productRepository) : IProductService
    {
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await productRepository.GetAllProducts();
        }
    }
}
