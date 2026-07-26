using Microsoft.AspNetCore.Mvc;

namespace ObadahVersionControlApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NameController : ControllerBase
{
    [HttpGet]
    public ActionResult<object> GetName()
    {
        return Ok(new { name = "Obadah Daraghmeh" });
    }
}
