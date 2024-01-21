namespace Invoice.Core;
public record class InvoiceTabInput : BaseEntityInput
{
    public int CustomerId { get; set; }
    public decimal Total { get; set; }
    public decimal DiscountAmount { get; set; }
}
