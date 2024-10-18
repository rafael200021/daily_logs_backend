using daily_log_api.IServices;
using daily_log_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace daily_log_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : DefaultController<User>
    {
        public readonly IUserService _service;

        public UserController(IUserService service) : base(service)
        {
            _service = service;
        }


        [HttpGet("Auth")]
        public async Task<IActionResult> GetUsuarioByToken()
        {

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))

                return Unauthorized("User not found");

            var user = await _service.GetById(int.Parse(userId));

            return Ok(user);
        }

    }
}
