using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeckStyleController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly INeckStyleService _neckStyleService;
        public NeckStyleController(IMapper mapper, INeckStyleService neckStyleService) {
            _mapper = mapper;
            _neckStyleService = neckStyleService;
        }
        #region
        [HttpGet("getNeckStyles")]
        public IActionResult GetNeckStyle()
        {
            var fab = _neckStyleService.GetNeckStyle();
            return Ok(fab);
        }
        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
