using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.DTOs;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainCategoryController : ControllerBase
    {
        private readonly IMainCategoryService _mainCategoryService;
        public MainCategoryController(IMainCategoryService mainCategoryService) 
        {
            _mainCategoryService = mainCategoryService;
        }
        #region GET

        [HttpGet("getMainCategory")]
        public IActionResult GetMainCategory()
        {
            var mainCate = _mainCategoryService.GetMainCategory();
            return Ok(mainCate);
        }

        #endregion
        #region POST
        [HttpPost("addMainCategory")]
        public IActionResult Register([FromBody] MainCategoryAddModel model)
        {

            _mainCategoryService.AddMainCategory(model);
            return Ok("User registered successfully");
        }
        #endregion
    }
}
