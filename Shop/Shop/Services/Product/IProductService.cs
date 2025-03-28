using Shop.Models.Requests.Product;
using Shop.Models.Responses.Product;

namespace Shop.Services.Product
{
    public interface IProductService
    {
        public Task<GetProductResponse> GetProductAsync(int id);
        public Task<GetProductsListResponse> GetProductsListAsync(int? userId);
        public Task CreateProductAsync(CreateProductRequest request);
        public Task UpdateProductAsync(UpdateProductRequest request);
        public Task DeleteProductAsync(int id);

    }
}
