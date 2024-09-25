using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.DTOs;
using SportsOrderApp.Entities;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserService _userService;

        public AuthController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            if (_userService.ValidateUser(model.UserName, model.Password))
            {
                var token = _userService.GenerateJwtToken(model.UserName);
                return Ok(new { token });
            }

            return Unauthorized("Invalid username or password");
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterModel model)
        {
            
            _userService.RegisterUser(model);
            return Ok("User registered successfully");
        }
    }
}
