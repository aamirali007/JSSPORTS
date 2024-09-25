using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICityService   _cityService;
        public CityController(IMapper mapper, ICityService cityService) {
            _mapper = mapper;
            _cityService = cityService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
