using System.ComponentModel;

namespace EShopService.Models
{
    public class Product
    {
        public int id { get; set; }

        public string name { get; set; } = default!;

        public Category category { get; set; } = default!;

        public Guid created_by { get; set; }

    }
}
