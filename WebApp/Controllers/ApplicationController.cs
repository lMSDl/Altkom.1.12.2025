using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace WebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApplicationController : ControllerBase
{
    [HttpGet("info")]
    public ActionResult<object> GetInfo()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var info = new
        {
            ApplicationName = assembly.GetName().Name,
            Version = assembly.GetName().Version?.ToString(),
            Framework = Environment.Version.ToString(),
            MachineName = Environment.MachineName,
            OSVersion = Environment.OSVersion.ToString(),
            ProcessorCount = Environment.ProcessorCount,
            CurrentTime = DateTime.UtcNow
        };

        return Ok(info);
    }

    [HttpGet("health")]
    public ActionResult GetHealth()
    {
        return Ok(new { Status = "Healthy", Timestamp = DateTime.UtcNow });
    }
}
