using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderFlowGroupController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOrderFlowGroupService _orderFlowGroupService;
        public OrderFlowGroupController(IMapper mapper, IOrderFlowGroupService orderFlowGroupService) {
            _mapper = mapper;
            _orderFlowGroupService = orderFlowGroupService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
