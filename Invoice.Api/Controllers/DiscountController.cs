namespace Invoice.Api;

public class DiscountController:BaseGenericController<Discount,DiscountInput,DiscountToReturn>
{
    public DiscountController(IBaseGenericService<Discount,DiscountInput,DiscountToReturn> baseGenericService) 
    : base(baseGenericService) { }


}
