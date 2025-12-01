using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseController<T> : ControllerBase where T : class
{
    protected readonly IRepository<T> Repository;

    protected BaseController(IRepository<T> repository)
    {
        Repository = repository;
    }

    [HttpGet]
    public virtual ActionResult<IEnumerable<T>> GetAll()
    {
        var items = Repository.GetAll();
        return Ok(items);
    }

    [HttpGet("{id}")]
    public virtual ActionResult<T> GetById(int id)
    {
        var item = Repository.GetById(id);
        if (item == null)
            return NotFound();
        
        return Ok(item);
    }

    [HttpPost]
    public virtual ActionResult<T> Create([FromBody] T entity)
    {
        var created = Repository.Create(entity);
        return CreatedAtAction(nameof(GetById), new { id = GetEntityId(created) }, created);
    }

    [HttpPut("{id}")]
    public virtual ActionResult<T> Update(int id, [FromBody] T entity)
    {
        var updated = Repository.Update(id, entity);
        if (updated == null)
            return NotFound();
        
        return Ok(updated);
    }

    [HttpDelete("{id}")]
    public virtual ActionResult Delete(int id)
    {
        var result = Repository.Delete(id);
        if (!result)
            return NotFound();
        
        return NoContent();
    }

    protected abstract int GetEntityId(T entity);
}
