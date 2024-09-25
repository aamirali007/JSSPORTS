using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MockOrderRequestController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMockOrderRequestService _mockOrderRequestService;
        public MockOrderRequestController(IMapper mapper, IMockOrderRequestService mockOrderRequestService) {
            _mapper = mapper;
            _mockOrderRequestService = mockOrderRequestService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
