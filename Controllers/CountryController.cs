using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICountryService _countryService;
        public CountryController(IMapper mapper, ICountryService countryService) {
            _mapper = mapper;
            _countryService = countryService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
