using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IItemService _itemService;
        public ItemController(IMapper mapper, IItemService itemService) {
            _mapper = mapper;
            _itemService = itemService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
