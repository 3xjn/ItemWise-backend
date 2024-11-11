using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ItemWise.Controllers
{
    [ApiController]
    [Route("itemwise/v{v:apiVersion}/")]
    [ApiVersion(2)]
    public class ItemWiseV2 : ControllerBase
    {
        [MapToApiVersion(2)]
        [HttpGet("health")]
        public IActionResult HealthCheckV1()
        {
            return Ok("no im sickly!");
        }
    }
}