namespace MyPersonalWebsite.Models
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Product> Products { get; set; }
    }
}
