using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientAccountController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IClientAccountService _clientAccountService;
        public ClientAccountController(IMapper mapper, IClientAccountService clientAccountService) {
            _mapper = mapper;
            _clientAccountService = clientAccountService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
