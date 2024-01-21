namespace Invoice.Api;
public class InvoiceTabController : BaseApiController
{
    private readonly IGenericRepository<Product> _productsRepo;
    InvoiceTabController(IGenericRepository<Product> productsRepo)
    {
        _productsRepo = productsRepo;
    }
    ActionResult<InvoiceTab> Get() => Ok(_productsRepo.ListAllAsync());
    
    [HttpDelete("{id}")]
    async Task<ActionResult> Delete(int id)
    {
        var existingInvoiceTab = await _productsRepo.GetByIdAsync(id);
        await _productsRepo.DeleteAsync(existingInvoiceTab);
        return Ok();
    }
    [HttpGet("{id}")]
    ActionResult<InvoiceTab> Get(int id) => Ok(_productsRepo.GetByIdAsync(id));

    [HttpPost]
    ActionResult<InvoiceTab> Post([FromBody] Product product)
    {
        _productsRepo.AddAsync(product);
        return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public ActionResult<InvoiceTab> Put(int id, [FromBody] Product product)
    {
         _productsRepo.GetByIdAsync(id);

        _productsRepo.UpdateAsync(product);
        return Ok();
    }




}
