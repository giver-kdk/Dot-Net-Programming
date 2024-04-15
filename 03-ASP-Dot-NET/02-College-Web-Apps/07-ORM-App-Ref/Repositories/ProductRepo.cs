using _06_ORM_App.Models;

namespace _06_ORM_App.Repositories
{
    // Create ProductRepo from Interface of 'Product' as generic type
    public class ProductRepo : IRepository<Product>
    {
        // Dependency Injection 
        ProductDbContext _context = null;
        public ProductRepo(ProductDbContext context)
        {
            _context = context;
        }
        // Interface Implementation
        public void AddRecord(Product model)
        {
            // Add the product from the context
            _context.Add(model);
        }

        public Product DeleteRecord(Product model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllRecords(Product model)
        {
            throw new NotImplementedException();
        }

        public Product GetSingleRecord(int id)
        {
            throw new NotImplementedException();
        }

        public Product UpdateRecord(Product model)
        {
            throw new NotImplementedException();
        }
    }
}
