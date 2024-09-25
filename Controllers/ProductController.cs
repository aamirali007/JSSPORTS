using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService ;
        public ProductController(IMapper mapper, IProductService productService) {
            _mapper = mapper;
            _productService = productService;
        }
        #region
        [HttpGet("getProductBySubCateId")]
        public IActionResult GetProductBySubCateId(long id)
        {
            var mainCate = _productService.GetProductBySubCateId(id);
            return Ok(mainCate);
        }
        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
