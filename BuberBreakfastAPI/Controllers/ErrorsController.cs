using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfastAPI.Controllers
{
    public class ErrorsController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error()
        {
            return Problem();
        }
    }
}
