using Shop.Enums;

namespace Shop.Models.Requests.Product
{
    public class CreateProductRequest
    {

        public ProductType Type { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
    }
}
