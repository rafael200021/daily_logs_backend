using daily_log_api.IServices;
using daily_log_api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace daily_log_api.Controllers
{

    public class AuthModel
    {
        public string Email { get; set; }
        public string Password { get ; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        public readonly IAuthService _service;
        public AuthController(IAuthService service) {
        
            _service = service;
        }

        [HttpPost]
        public ActionResult Auth([FromBody] AuthModel authData)
        {

            TokenModel? token = _service.Auth(authData.Email, authData.Password);

            if(token == null) { return NotFound();  }

            return Ok(token);

        }

    }
}
