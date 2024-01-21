namespace Invoice.Api;

public class ProductController : BaseGenericController<Product, ProductInput, ProductToReturn>
{
    public ProductController(IBaseGenericService<Product, ProductInput, ProductToReturn> baseGenericService) : base(baseGenericService)
    {
    }
}
