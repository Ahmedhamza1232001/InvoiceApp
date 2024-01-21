namespace Invoice.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Customers = new GenericRepository<Customer>(_context);
        Discounts = new GenericRepository<Discount>(_context);
        Taxes = new GenericRepository<Tax>(_context);
        InvoiceTabs = new GenericRepository<InvoiceTab>(_context);
    }

    public IGenericRepository<Customer> Customers { get; private set;}
    public IGenericRepository<Discount> Discounts { get; private set;}
    public IGenericRepository<Tax> Taxes { get; private set;}
    public IGenericRepository<InvoiceTab> InvoiceTabs { get; private set;}
    public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
    {
        return new GenericRepository<TEntity>(_context);
    }
    public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();
    public void Dispose() => _context.Dispose();
    
}
