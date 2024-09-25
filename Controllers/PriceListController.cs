using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceListController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPriceListService _priceListService;
        public PriceListController(IMapper mapper, IPriceListService priceListService) {
            _mapper = mapper;
            _priceListService = priceListService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
