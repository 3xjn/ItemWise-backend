using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ItemWise.Controllers
{
    [ApiController]
    [Route("itemwise/v{v:apiVersion}/")]
    [ApiVersion(1)]
    public class ItemWiseV1 : ControllerBase
    {
        [MapToApiVersion(1)]
        [HttpGet("health")]
        public IActionResult HealthCheckV1()
        {
            return Ok("yea im healthy <3");
        }
    }
}