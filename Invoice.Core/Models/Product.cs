namespace Invoice.Core.Models;

public class Product : BaseEntity
{
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public ICollection<Discount>? Discounts { get; set; }
    public ICollection<InvoiceProduct>? InvoiceProducts { get; set; }

}