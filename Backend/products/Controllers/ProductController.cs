
using Microsoft.AspNetCore.Mvc;
using products.BLL.Services;

namespace products.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController(IProductService productService) : Controller
    {
        [HttpGet("get-products")]
        public async Task<IActionResult> GetProducts()
        {
            var products = await productService.GetProductsAsync();
            return Ok(products);
        }
        
    }
}
