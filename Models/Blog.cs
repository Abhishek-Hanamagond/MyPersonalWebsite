using System;
using System.ComponentModel.DataAnnotations;

namespace MyPersonalWebsite.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
