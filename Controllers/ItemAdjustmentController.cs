using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemAdjustmentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IItemAdjustmentService _itemAdjustmentService;
        public ItemAdjustmentController(IMapper mapper, IItemAdjustmentService itemAdjustmentService) {
            _mapper = mapper;
            _itemAdjustmentService = itemAdjustmentService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
