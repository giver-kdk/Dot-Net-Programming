using Microsoft.EntityFrameworkCore;

namespace _06_ORM_App.Models
{
    // Inherit 'ProductDbContext' from 'DbContext'
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base()
        {

        }
        // Here, name of the table will be 'products'
        DbSet<Product> products;
    }
}
