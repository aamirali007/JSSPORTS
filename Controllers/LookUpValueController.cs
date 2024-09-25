using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookUpValueController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILookUpValueService _lookUpValueService;
        public LookUpValueController(IMapper mapper, ILookUpValueService lookUpValueService) {
            _mapper = mapper;
            _lookUpValueService = lookUpValueService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
