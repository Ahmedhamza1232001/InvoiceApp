namespace Invoice.Core;

public record class CustomerToReturn : BaseEntityToReturn
{
    public required string Name { get; set; }
    public int Age { get; set; }
}
