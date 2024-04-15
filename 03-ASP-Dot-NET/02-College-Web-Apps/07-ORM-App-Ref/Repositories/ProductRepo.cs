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
            // Add the product from the context. Here, still DB is not updated
            _context.Add(model);
            // Here, the changes are saved usign 'SaveChanges()' method
            _context.SaveChanges();
        }

        public Product DeleteRecord(Product model)
        {
            _context.Remove(model);
            return model;
        }

        public IEnumerable<Product> GetAllRecords()
        {
            List<Product> allProducts = _context.Products.ToList();
            return allProducts;

        }

        public Product GetSingleRecord(int id)
        {
            // Similar tp using 'WHERE' clause in SQL to find based on 'id'
            Product p = _context.Products.Find(id);
            return p;
        }

        public Product UpdateRecord(Product model)
        {
            _context.Update(model);
            return model;
        }
    }
}
