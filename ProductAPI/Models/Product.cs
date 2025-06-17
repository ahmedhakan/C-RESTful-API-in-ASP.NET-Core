using Microsoft.AspNetCore.Authentication;

namespace ProductAPI.Models
{
    public class Product
    {
        public  int id  { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
