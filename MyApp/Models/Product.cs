using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EShopService.Models
{
    public class Product : BaseModel
    {
        public string Ean { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; } = 0;
        public string Sku { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
    }
}
