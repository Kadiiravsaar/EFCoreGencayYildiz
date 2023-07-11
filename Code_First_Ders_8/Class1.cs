using Microsoft.EntityFrameworkCore;

public class ECommerceDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-G34LNC7;Database=ECommerce;Trusted_Connection=true;TrustServerCertificate=True;");
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }

}

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }

}