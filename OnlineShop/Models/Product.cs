using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool Active { get; set; }
        public int? Price { get; set; }
        public int? BrandID { get; set; }
        public int? CategoryID { get; set; }
    }
}

