using ERP.APPLICATION.DTOs.Auth;
using ERP.APPLICATION.Services;
using Microsoft.AspNetCore.Mvc;

namespace ERP.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(IAuthService _service) : ControllerBase
{
    [HttpPost("{login}")]
    public async Task<ActionResult<TokenDTO>> Login(LoginDTO login)
    {
        return await _service.Login(login);
    }
    
}