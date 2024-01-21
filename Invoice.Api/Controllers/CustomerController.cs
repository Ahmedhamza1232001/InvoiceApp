namespace Invoice.Api;
public class CustomerController : BaseGenericController<Customer,CustomerInput,CustomerToReturn>
{
    public CustomerController(IBaseGenericService<Customer,CustomerInput,CustomerToReturn> baseGenericService)
     : base(baseGenericService) { }


}
