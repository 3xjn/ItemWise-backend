using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ItemWise.Controllers
{
    [ApiVersion(1)]
    [ApiVersion(2)]
    [ApiController]
    [Route("itemwise/v{v:apiVersion}/")]
    public class ItemWise : ControllerBase
    {
        [MapToApiVersion(1)]
        [HttpGet("health")]
        public IActionResult HealthCheckV1()
        {
            return Ok("yea im healthy <3");
        }

        [MapToApiVersion(2)]
        [HttpGet("health")]
        public IActionResult HealthCheckV2()
        {
            return Ok("no im sickly!");
        }
    }
}
