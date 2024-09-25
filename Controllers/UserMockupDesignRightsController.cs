using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Core;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMockupDesignRightsController : ApiControllerExtensions
    {
        private readonly IUserMockupDesignRightsService _userMockupDesignRightsService;
        public UserMockupDesignRightsController(IUserMockupDesignRightsService userMockupDesignRightsService)
        {
            _userMockupDesignRightsService = userMockupDesignRightsService;
        }
        #region GET
        [HttpGet("userMockupDesignActionRights")]
        public IActionResult GetUerMockupDesignActionRights()
        {
            var userRight = _userMockupDesignRightsService.GetUerMockupDesignActionRights(2);
            return Ok(userRight);
        }
        #endregion
    }
}
