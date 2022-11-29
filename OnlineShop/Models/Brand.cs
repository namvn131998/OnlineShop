using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }
        [Required]
        public string? BrandName { get; set; }
        public string? BrandDescription { get; set; }
    }
}
