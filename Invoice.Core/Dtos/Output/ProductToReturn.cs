namespace Invoice.Core;

public record class ProductToReturn : BaseEntityToReturn
{
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
