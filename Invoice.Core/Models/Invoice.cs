namespace Invoice.Core.Models;
public class Invoice{

    public int CustomerId { get; set; } 
    public required Customer Customer { get; set; } 
    public List<InvoiceProduct> Items { get; set; } = new(); 
}