using ERP.APPLICATION.DTOs;
using ERP.APPLICATION.Services;
using ERP.DOMAIN.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ERP.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(IUserService _service) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<User>> CreateUser([FromBody] CreateUserDTO user)
    {
        return Ok(await _service.CreateUser(user));
    }
}