using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Models.Requests.Product;
using Shop.Models.Responses.Product;
using Shop.Services.Product;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetProductResponse>> GetProduct(int id)
        {
            return await _productService.GetProductAsync(id);
        }

        /// <summary>
        /// Returns user's products by parameter or all products if not given parameter
        /// </summary>
        [HttpGet("products")]
        public async Task<ActionResult<GetProductsListResponse>> GetProductsList(int? userId)
        {
            return await _productService.GetProductsListAsync(userId);
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduct(CreateProductRequest request)
        {
            await _productService.CreateProductAsync(request);
            return Ok(request);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateProduct(UpdateProductRequest request)
        {
            await _productService.UpdateProductAsync(request);
            return Ok(request);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteProductAsync([Required] int id)
        {
            await _productService.DeleteProductAsync(id);
            return Ok();
        }
    }
}
