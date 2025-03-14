using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[] { "Emre Erdem", "Zafer Emir Surucu", "Yusuf Kaya", "Fahri Ulkat", "Celal Eren Gencer" });
        }
    }
}
