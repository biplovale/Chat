using Microsoft.AspNetCore.Mvc;

namespace ChatApi.Controllers
{
    /// <summary>
    /// Represents a controller for handling DashBoard requests.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class DashBoardController : Controller
    {
        /// <summary>
        /// Gets something
        /// </summary>
        /// <returns>The something.</returns>
        [HttpGet("/something")]
        public IActionResult Index()
        {
            return Ok("something");
        }
    }
}
