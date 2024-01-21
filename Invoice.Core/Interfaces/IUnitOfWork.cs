namespace Invoice.Core;

public interface IUnitOfWork: IDisposable
{
    IGenericRepository<Customer> Customers { get; }
    IGenericRepository<Discount> Discounts { get; }
    IGenericRepository<Tax> Taxes { get; }
    IGenericRepository<InvoiceTab> InvoiceTabs { get; }

    IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
    //make the return type int to return the number of Afected rows 
    Task<int> CompleteAsync();
}
