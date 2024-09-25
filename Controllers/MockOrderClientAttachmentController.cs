using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MockOrderClientAttachmentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMockOrderClientAttachmentService _mockOrderClientAttachmentService;
        public MockOrderClientAttachmentController(IMapper mapper, IMockOrderClientAttachmentService mockOrderClientAttachmentService) {
            _mapper = mapper;
            _mockOrderClientAttachmentService = mockOrderClientAttachmentService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
