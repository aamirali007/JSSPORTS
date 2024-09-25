using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FabricTypeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IFabricTypeService _fabricTypeService;
        public FabricTypeController(IMapper mapper, IFabricTypeService fabricTypeService) {
            _mapper = mapper;
            _fabricTypeService = fabricTypeService;
        }
        #region
        [HttpGet("getFabricTypes")]
        public IActionResult GetProductBySubCateId()
        {
            var fab = _fabricTypeService.GetFabricTypes();
            return Ok(fab);
        }
        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
