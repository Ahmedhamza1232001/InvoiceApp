namespace Invoice.Core.Models;
public class InvoiceTab : BaseEntity
{

    public int CustomerId { get; set; }
    public required Customer Customer { get; set; }
    public decimal Total { get; set; }
    public List<InvoiceProduct>? InvoiceProducts { get; set; } 
    public ICollection<Addon>? Addons { get; set; }
    public decimal DiscountAmount { get; set; }
}