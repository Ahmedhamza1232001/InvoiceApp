namespace Invoice.Core;

public interface IBaseGenericService<T, Tinput, Toutput>
{
    Task<IReadOnlyList<T>> GetAllEntities();
    Task<Toutput> GetEntityById(int id);
    Task<Toutput> AddEntityAsync(Tinput input);
    Task DeleteEntityAsync(int id);
    Task<Toutput> UpdateEntityAsync(int id, Tinput input);
}
