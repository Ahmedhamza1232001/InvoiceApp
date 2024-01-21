namespace Invoice.Core.Models;
public class InvoiceTab : BaseEntity
{

    public int CustomerId { get; set; }
    public Customer? Customer { get; set; } //need to make migration and remove nullabel from here
    public decimal Total { get; set; }
    public List<InvoiceProduct>? InvoiceProducts { get; set; } 
    public ICollection<Addon>? Addons { get; set; }
    public decimal DiscountAmount { get; set; }
}