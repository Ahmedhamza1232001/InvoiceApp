namespace Invoice.Api;

public class DiscountController:BaseApiController
{
    private readonly IGenericRepository<Discount> _discountsRepo;

    public DiscountController(IGenericRepository<Discount> discountsRepo)
    {
        _discountsRepo = discountsRepo;
    }
}
