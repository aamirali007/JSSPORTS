using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientRoleSController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IClientRoleService _roleService;
        public ClientRoleSController(IMapper mapper, IClientRoleService clientRoleService) {
            _mapper = mapper;
            _roleService = clientRoleService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
