namespace Invoice.Api;
[ApiController]
[Route("api/[controller]")]
public abstract class BaseGenericController<T, Tinput, Toutput> : ControllerBase
    where T : BaseEntity
    where Tinput : BaseEntityInput
    where Toutput : BaseEntityToReturn
{
    IBaseGenericService<T,Tinput,Toutput> _baseGenericService;

    protected BaseGenericController(IBaseGenericService<T,Tinput,Toutput> baseGenericService)
    {
        _baseGenericService = baseGenericService;
    }

    [HttpGet]
    public virtual async Task<ActionResult<IReadOnlyList<T>>> Get() =>
    Ok(await _baseGenericService.GetAllEntities());

    [HttpGet("{id}")]
    public virtual async Task<ActionResult<T>> Get(int id) =>
        Ok(await _baseGenericService.GetEntityById(id));
    [HttpPost]
    public virtual async Task<ActionResult<Toutput>> Add([FromBody] Tinput input)
    {
        Toutput entityToReturn = await _baseGenericService.AddEntityAsync(input);
        return CreatedAtAction(nameof(Get), new { id = entityToReturn.Id }, entityToReturn);
    }

    [HttpDelete("{id}")]
    public virtual async Task<ActionResult> Delete(int id)
    {
        await _baseGenericService.DeleteEntityAsync(id);
        return Ok();
    }

    [HttpPut("{id}")]
    public virtual async Task<ActionResult<Toutput>> Update(int id, [FromBody] Tinput input)
    {
        Toutput updatedEntity = await _baseGenericService.UpdateEntityAsync(id, input);
        return Ok(updatedEntity);
    }

}