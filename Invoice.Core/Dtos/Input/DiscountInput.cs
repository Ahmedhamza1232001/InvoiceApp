namespace Invoice.Core;
public record class DiscountInput : BaseEntityInput
{
    public AddonType AddonType { get; set; }
    public decimal Value { get; set; }
    public bool IsAuto { get; set; }
    public bool IsPercent { get; set; }
}
