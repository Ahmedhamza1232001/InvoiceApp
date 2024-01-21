namespace Invoice.Api;

public class BaseGenericService<T, Tinput,Toutput> : IBaseGenericService<T, Tinput,Toutput>
    where T : BaseEntity
    where Tinput : BaseEntityInput
    where Toutput : BaseEntityToReturn
{
    protected readonly IUnitOfWork _unitOfWork;
    protected readonly IMapper _mapper;

    public BaseGenericService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<T>> GetAllEntities()
    {
        return await _unitOfWork.Repository<T>().ListAllAsync();
    }

    public async Task<Toutput> GetEntityById(int id)
    {
        T entity = await _unitOfWork.Repository<T>().GetByIdAsync(id);
        Toutput mappedEntity = _mapper.Map<Toutput>(entity);
        return mappedEntity;
    }
    public async Task<Toutput> AddEntityAsync(Tinput input)
    {
        T entity = Activator.CreateInstance<T>();
        entity = _mapper.Map(input, entity);
        await _unitOfWork.Repository<T>().AddAsync(entity);
        await _unitOfWork.CompleteAsync();

        Toutput entityToReturn = Activator.CreateInstance<Toutput>();
        entityToReturn = _mapper.Map(entity, entityToReturn);

        return entityToReturn;
    }

    public async Task DeleteEntityAsync(int id)
    {
        T entity = await _unitOfWork.Repository<T>().GetByIdAsync(id);
        _unitOfWork.Repository<T>().Delete(entity);
        await _unitOfWork.CompleteAsync();
    }

    public async Task<Toutput> UpdateEntityAsync(int id, Tinput input)
    {
        T entity = await _unitOfWork.Repository<T>().GetByIdAsync(id);
        _mapper.Map(input, entity);
        _unitOfWork.Repository<T>().Update(entity);
        await _unitOfWork.CompleteAsync();

        Toutput updatedEntity = _mapper.Map<Toutput>(entity);
        return updatedEntity;
    }



}
