namespace Invoice.Api;
public class InvoiceTabController : BaseGenericController<InvoiceTab,InvoiceTabInput,InvoiceTabToReturn>
{
    public InvoiceTabController(IBaseGenericService<InvoiceTab,InvoiceTabInput,InvoiceTabToReturn> baseGenericService)
        : base(baseGenericService) { }

}
