using Microsoft.AspNetCore.Mvc;
using Models;
using Repositories;

namespace WebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : BaseController<User>
{
    public UserController(IRepository<User> repository) : base(repository)
    {
    }

    protected override int GetEntityId(User entity)
    {
        return entity.Id;
    }
}
