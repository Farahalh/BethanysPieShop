using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    // Define a DbContext class named BethanysPieShopDbContext that inherits from DbContext.
    public class BethanysPieShopDbContext : DbContext
    {
        // Constructor that takes DbContextOptions as a parameter, typically injected by dependency injection.
        public BethanysPieShopDbContext(DbContextOptions<BethanysPieShopDbContext> options) : base(options)
        {
            // Constructor initializes the DbContext using the provided options.
            // This constructor is often used for dependency injection of the database context.
        }

        // DbSet<Category> property represents a table of Category entities in the database.
        public DbSet<Category> Categories { get; set; }

        // DbSet<Pie> property represents a table of Pie entities in the database.
        public DbSet<Pie> Pies { get; set; }
    }
}
