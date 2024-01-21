namespace Invoice.Core;

public record class InvoiceTabToReturn : BaseEntityToReturn
{
    public int CustomerId { get; set; }
    public decimal Total { get; set; }
    public decimal DiscountAmount { get; set; }
}
