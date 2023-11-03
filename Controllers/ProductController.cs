using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gaming_Store.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gaming_Store.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductRepository _product;

        public ProductController(ILogger<ProductController> logger,
                                IProductRepository IProductRepository)
        {
            _logger = logger;
            _product = IProductRepository;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllProducts()
        {
            var Products = await _product.GetAllProducts();
            return Ok(Products);
        }

        [HttpGet("GetById/{Id}")]
        public async Task<IActionResult> GetProductById(int Id)
        {
            var product = await _product.GetProductById(Id);
            if (product == null)
            {
                return BadRequest("this product not exist!");
            }

            return Ok(product);
        }
    }
}
