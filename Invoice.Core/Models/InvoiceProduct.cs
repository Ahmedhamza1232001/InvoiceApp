namespace Invoice.Core.Models;

public class InvoiceProduct : BaseEntity
{   
    public int Quantity { get; set; }
    public int InvoiceId { get; set; } 
    public InvoiceTab? Invoice { get; set; } 
    public int ProductId { get; set; }
    public Product? Product { get; set; }
}



