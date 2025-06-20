using Microsoft.AspNetCore.Mvc;
namespace BooklyBookStoreApp.Presentation.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public sealed class TestController:ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Api Test is successfull");
        }
        [HttpGet("Beyza")]
        public IActionResult GetBeyza()
        {
            return Ok("Beyza");
        }

    }
}
