using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePizza.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost]
        [Route("register-user")]

        public async Task<IActionResult> RegisterUser()
        {
            return Ok();
        }

        [HttpPost]
        [Route("validate-user")]
        public async Task<IActionResult> ValidateUser()
        {
            return Ok();
        }
    }
}
