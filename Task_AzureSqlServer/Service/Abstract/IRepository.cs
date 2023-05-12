using Task_AzureSqlServer.Models;

namespace Task_AzureSqlServer.Service.Abstract
{
    public interface IRepository
    {


        public List<Product> GetProducts();
        public List<ProductCategory> GetCategories();
        public Product GetProduct(int id);
        public ProductCategory GetCategory(int id);
        public List<Product> GetProductsForCategory(int categoryId);
    }
}
