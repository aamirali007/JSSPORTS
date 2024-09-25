using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MockOrderDesignAttachmentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMockOrderDesignAttachmentService _mockOrderDesignAttachmentService;
        public MockOrderDesignAttachmentController(IMapper mapper, IMockOrderDesignAttachmentService mockOrderDesignAttachmentService) {
            _mapper = mapper;
            _mockOrderDesignAttachmentService = mockOrderDesignAttachmentService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
