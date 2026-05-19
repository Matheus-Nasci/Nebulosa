using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Nebulosa.Application.Interfaces;

namespace Nebulosa.Controller;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    private readonly ILogger<AuthController> _logger;

    public AuthController(IAuthService authService, ILogger<AuthController> logger)
    {
        _logger = logger;
        _authService = authService;
    }
    
    [HttpPost]
    public object GetAuthentication(object user)
    {
        return _authService.AuthJwtUser(user);
    }
}