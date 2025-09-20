using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyPersonalWebsite.Models
{
    public class Seller
    {
        public int SellerId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        public List<Product> Products { get; set; }
    }
}
