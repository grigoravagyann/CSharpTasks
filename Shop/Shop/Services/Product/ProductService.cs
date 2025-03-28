using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Data.Entities;
using Shop.Models.Requests.Product;
using Shop.Models.Responses.Product;

namespace Shop.Services.Product
{
    public class ProductService : IProductService
    {
        public readonly AppDbContext _dbContext;
        public ProductService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetProductResponse> GetProductAsync(int id)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id)
                ?? throw new InvalidOperationException($"Product with id {id} not found");

            return new GetProductResponse { 
                Id = product.Id,
                Type = product.Type.ToString(),
                Price = product.Price,
                Quantity = product.Quantity,
                UserId = product.UserId,
                Name = product.Name
            };
        }

        public async Task<GetProductsListResponse> GetProductsListAsync(int? userId)
        {
            var products = await _dbContext.Products.ToListAsync();

            if (userId != null)
                products = products.Where(p => p.UserId == userId).ToList();

            var productsList = new List<GetProductResponse>();
            foreach (var product in products)
            {
                productsList.Add(new GetProductResponse
                {
                    Id = product.Id,
                    Name = product.Name,
                    Type = product.Type.ToString(),
                    Price = product.Price,
                    Quantity = product.Quantity,
                    UserId = product.UserId
                });
            }

            return new GetProductsListResponse
            {
                Products = productsList,
                TotalCount = productsList.Count()
            };
        }

        public async Task CreateProductAsync(CreateProductRequest request)
        {
            var product = new Shop.Data.Entities.Product
            {
                Name = request.Name,
                Price = request.Price,
                Quantity = request.Quantity,
                UserId = request.UserId,
                Type = request.Type

            };
            
            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(UpdateProductRequest request)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == request.Id)
                ?? throw new InvalidDataException($"Product with id {request.Id} not found");

            product.Quantity = request.Quantity;
            product.Price = request.Price;
            product.UserId = request.UserId;
            product.Type = request.Type;
            product.Name = request.Name;

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id)
                ?? throw new InvalidDataException($"Product with id {id} not found");

            _dbContext.Remove(product);
            await _dbContext.SaveChangesAsync();
        }
    }
}
