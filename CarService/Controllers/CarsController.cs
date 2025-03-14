using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarService.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[] { "34ABC11 : Clio", "34ABC12 : Clio", "34AB21 : Vito", "34CA54 : SuperB" });
        }
    }
}
