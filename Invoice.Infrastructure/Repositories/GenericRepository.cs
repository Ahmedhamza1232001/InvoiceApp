namespace Invoice.Infrastructure;
public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly ApplicationDbContext _context;
    public GenericRepository(ApplicationDbContext context) => _context = context;
    public async Task<T> GetByIdAsync(int id) => await _context.Set<T>()
        .FindAsync(id)?? throw new NullReferenceException("Entity not found");
    public async Task<IReadOnlyList<T>> ListAllAsync() => await _context.Set<T>().ToListAsync();
    public async Task AddAsync(T entity) => await _context.Set<T>().AddAsync(entity);
    public async Task UpdateAsync(T entity) =>  _context.Set<T>().Update(entity); // add save changes async and add unit of work
    public async Task DeleteAsync(T entity) => _context.Set<T>().Remove(entity);

    
}
