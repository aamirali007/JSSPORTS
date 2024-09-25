using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.DTOs;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISubCategoryService _subCategoryService;
        public SubCategoryController(IMapper mapper, ISubCategoryService subCategoryService)
        {
            _mapper = mapper;
            _subCategoryService = subCategoryService;
        }
        #region
        [HttpGet("getCategory")]
        public IActionResult GetCategory()
        {
            var mainCate = _subCategoryService.GetSubCategory();
            return Ok(mainCate);
        }
        [HttpGet("getSubCategoryBySubCatId")]
        public IActionResult GetSubCategoryBySubCatId(long id)
        {
            var mainCate = _subCategoryService.GetSubCategoryBySubCatId(id);
            return Ok(mainCate);
        }
        #endregion

        #region POST
        [HttpPost("addSubCategory")]
        public IActionResult Register([FromBody] SubCategoryAddModel model)
        {

            _subCategoryService.AddSubCategory(model);
            return Ok("User registered successfully");
        }

        #endregion
    }
}
