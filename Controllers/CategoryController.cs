using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.DTOs;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        public CategoryController(IMapper mapper, ICategoryService categoryService) {
            _mapper = mapper;
            _categoryService = categoryService;
        }
        #region GET
        [HttpGet("getCategory")]
        public IActionResult GetCategory()
        {
            var mainCate = _categoryService.GetMainCategory();
            return Ok(mainCate);
        }

        [HttpGet("getCategoryByMainId")]
        public IActionResult GetCategoryByMainId(long mainCatId)
        {
            var mainCate = _categoryService.GetMainCategoryByMainCategoryId(mainCatId);
            return Ok(mainCate);
        }
        #endregion

        #region POST
        [HttpPost("addCategory")]
        public IActionResult Register([FromBody] CategoryAddModel model)
        {

            _categoryService.AddCategory(model);
            return Ok("User registered successfully");
        }

        #endregion

        #region

        #endregion
    }
    }
