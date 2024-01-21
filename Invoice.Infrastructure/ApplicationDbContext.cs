global using Invoice.Core.Interfaces;
global using Invoice.Core.Models;
global using Microsoft.EntityFrameworkCore;
global using Invoice.Core;

namespace Invoice.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Addon>().UseTpcMappingStrategy();
        modelBuilder.Entity<BaseEntity>().UseTpcMappingStrategy();

        modelBuilder.Entity<Addon>()
            .Property(a => a.Value)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<InvoiceTab>()
            .Property(a => a.Total)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<InvoiceTab>()
            .Property(a => a.DiscountAmount)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Product>()
           .Property(a => a.Price)
           .HasColumnType("decimal(18,2)");
        base.OnModelCreating(modelBuilder);

    }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<InvoiceTab> InvoiceTabs { get; set; }
    public DbSet<InvoiceProduct> InvoiceProducts { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Tax> Taxes { get; set; }

}
