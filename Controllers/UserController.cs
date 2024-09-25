using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) 
        {
            _userService = userService;
        }


        #region GET
        [HttpGet("clientList")]
        public IActionResult GetClientUserList()
        {
            var client = _userService.GetClientUserList();
            return Ok(client);
        }
        #endregion
    }


}
