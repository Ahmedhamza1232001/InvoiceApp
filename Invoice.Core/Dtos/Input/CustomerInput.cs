namespace Invoice.Core;

public record class CustomerInput : BaseEntityInput
{
    public required string Name { get; set; }
    public int Age { get; set; }
}
