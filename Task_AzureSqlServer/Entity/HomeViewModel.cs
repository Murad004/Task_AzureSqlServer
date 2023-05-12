using Task_AzureSqlServer.Models;

namespace Task_AzureSqlServer.Entity
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }
        public List<ProductCategory> Categories { get; set; }

        public int CategoryId { get; set; }
    }
}
