using Microsoft.AspNetCore.Mvc;

namespace Nebulosa.Controller;

[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult HealthcheckApplication()
    {
        return Ok("Health");
    }
}