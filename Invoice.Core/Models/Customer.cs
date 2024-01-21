namespace Invoice.Core.Models;
public class Customer : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    
}