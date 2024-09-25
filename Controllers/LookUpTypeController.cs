using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookUpTypeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILookUpTypeService _lookUpTypeService;
        public LookUpTypeController(IMapper mapper, ILookUpTypeService lookUpTypeService) {
            _mapper = mapper;
            _lookUpTypeService = lookUpTypeService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
