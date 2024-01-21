namespace Invoice.Api;

public class CustomerController:BaseApiController
{
    private readonly IGenericRepository<Customer> _customersRepo;

    public CustomerController(IGenericRepository<Customer> customersRepo)
    {
        _customersRepo = customersRepo;
    }
}
