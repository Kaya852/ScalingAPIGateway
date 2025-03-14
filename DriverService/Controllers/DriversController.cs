using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DriverService.Controllers
{
    [Route("api/drivers")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[] { "Burak Kaya", "Murat Sadik Kaya", "Berkay Dulgerbaki", "Mertcan Tabakoglu" });
        }
    }
}
