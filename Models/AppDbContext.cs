using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace MyPersonalWebsite.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
    }
}
