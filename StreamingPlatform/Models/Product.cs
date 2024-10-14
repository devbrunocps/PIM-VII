using System.ComponentModel.DataAnnotations;

namespace StreamingPlatform.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Category { get; set; }
        public string Manufacturer { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Platform { get; set; }
        public int WarrantyPeriod { get; set; }
    }
}
