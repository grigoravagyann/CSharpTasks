using Shop.Enums;

namespace Shop.Models.Responses.Product
{
    public class GetProductResponse
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
    }
}
