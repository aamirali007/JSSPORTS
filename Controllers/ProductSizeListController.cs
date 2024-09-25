using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSizeListController : ControllerBase
    {
        private readonly IProductSizeListService _productSizeListService;
        public ProductSizeListController(IProductSizeListService productSizeListService) 
        {
            _productSizeListService = productSizeListService;
        }

        #region Get
        [HttpGet("getProductSizes")]
        public IActionResult GetProductSizes()
        {
            var fab = _productSizeListService.GetProductSizes();
            return Ok(fab);
        }
        #endregion
    }
}
