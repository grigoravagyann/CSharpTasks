using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Shop.Enums;

namespace Shop.Data.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public ProductType Type { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Quantity { get; set; }     
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
