namespace Invoice.Core.Models;
public class Customer : BaseEntity
{

    public required string Name { get; set; }
    public int Age { get; set; }

}