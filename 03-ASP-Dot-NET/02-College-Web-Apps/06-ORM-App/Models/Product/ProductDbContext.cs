using Microsoft.EntityFrameworkCore;

namespace _06_ORM_App.Models
{
    // Inherit 'ProductDbContext' from 'DbContext'
    public class ProductDbContext : DbContext
    {
        // Constructor needs to accept 'DbContextOptions' object and pass it to base constructor
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        // Here, name of the table will be 'products'
        DbSet<Product> products;
    }
}
