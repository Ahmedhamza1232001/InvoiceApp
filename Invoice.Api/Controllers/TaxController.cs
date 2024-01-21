namespace Invoice.Api;

public class TaxController : BaseGenericController<Tax,TaxInput,TaxToReturn>
{
    public TaxController(IBaseGenericService<Tax,TaxInput,TaxToReturn> baseGenericService)
     :base(baseGenericService)
    {
        
    }
    
}
