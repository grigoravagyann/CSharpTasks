using System.ComponentModel.DataAnnotations;
using Shop.Enums;

namespace Shop.Models.Requests.Product
{
    public class UpdateProductRequest
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public ProductType Type { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
