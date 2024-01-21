namespace Invoice.Core;
public record class BaseEntityToReturn
{
    public int Id { get; set; }
    public DateTime CreationTime { get; set; }
    public DateTime ModificationTime { get; set; }
}
