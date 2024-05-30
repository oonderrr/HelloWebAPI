using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        // Dependency Injection 
        private readonly ILogger<ProductsController> _logger;
        public ProductsController (ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    ProductName = "Computer"
                },
                new Product()
                {
                    Id = 2,
                    ProductName = "Phone"
                },
                new Product()
                {
                    Id = 3,
                    ProductName = "Mouse"
                }
            };
            
            _logger.LogInformation("GetAllProducts action has been called.");
            return Ok(products);
        }
    }
}

