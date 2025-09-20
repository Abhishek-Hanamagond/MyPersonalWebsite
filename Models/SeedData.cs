using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace MyPersonalWebsite.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

                context.Products.AddRange(
                    new Product
                    {
                        Name = "Laptop",
                        Description = "A high-performance laptop.",
                        Price = 75000.00m,
                        ImageUrl = "/images/laptop.jpg"
                    },
                    new Product
                    {
                        Name = "Smartphone",
                        Description = "A latest model smartphone.",
                        Price = 50000.00m,
                        ImageUrl = "/images/smartphone.jpg"
                    },
                    new Product
                    {
                        Name = "Headphones",
                        Description = "Noise-cancelling headphones.",
                        Price = 10000.00m,
                        ImageUrl = "/images/headphones.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
