using Task_AzureSqlServer.Models;
using Task_AzureSqlServer.Service.Abstract;

namespace Task_AzureSqlServer.Service.Concrete
{
    public class Repository : IRepository
    {
        private Muradsadikhov39Context _context;

        public Repository(Muradsadikhov39Context context)
        {
            _context = context;
        }

        public List<ProductCategory> GetCategories()
        {
            return _context.ProductCategories.ToList();
        }

        public ProductCategory GetCategory(int id)
        {
            return _context.ProductCategories.Find(id);
        }

        public Product GetProduct(int id)
        {
            return _context.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public List<Product> GetProductsForCategory(int categoryId)
        {
            return _context.Products.Where(p => p.ProductCategoryId == categoryId).ToList();
        }
    }
}
