using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GRNController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IGRNService _grnService;
        public GRNController(IMapper mapper, IGRNService gRNService) {
            _mapper = mapper;
            _grnService = gRNService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
