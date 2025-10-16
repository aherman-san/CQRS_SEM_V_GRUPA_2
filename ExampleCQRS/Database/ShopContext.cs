using ExampleCQRS.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExampleCQRS.Database;

public class ShopContext : DbContext
{
    public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }

    public virtual required DbSet<Category> Categories { get; set; }
    public virtual required DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products);

        var categories = CreateInitialCategories();
        modelBuilder.Entity<Category>().HasData(categories);
    }


    private static Category[] CreateInitialCategories()
    {
        var categories = new List<Category>
        {
            new Category { Id = 1, CreatedAt = new DateTime(2025, 10, 16, 0, 0, 0), Name = "Telewizory" },
            new Category { Id = 2, CreatedAt = new DateTime(2025, 10, 16, 0, 0, 0), Name = "Laptopy" },
            new Category { Id = 3, CreatedAt = new DateTime(2025, 10, 16, 0, 0, 0), Name = "AGD" },
            new Category { Id = 4, CreatedAt = new DateTime(2025, 10, 16, 0, 0, 0), Name = "Oprogramowanie" },
            new Category { Id = 5, CreatedAt = new DateTime(2025, 10, 16, 0, 0, 0), Name = "Audio-Video" }
        };

        return categories.ToArray();
    }
}
