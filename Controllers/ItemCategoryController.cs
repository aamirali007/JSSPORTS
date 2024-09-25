using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemCategoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IItemCategoryService _itemCategoryService;
        public ItemCategoryController(IMapper mapper, IItemCategoryService itemCategoryService) {
            _mapper = mapper;
            _itemCategoryService = itemCategoryService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
