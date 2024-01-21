namespace Invoice.Core.Models;

public class InvoiceProduct{
    public int Id { get; set; }
    public string? Description { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    public int InvoiceId { get; set; } // Foreign key for Invoice
    public required Invoice Invoice { get; set; } // Navigation property
}



