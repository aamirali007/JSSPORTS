using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsOrderApp.Services;

namespace SportsOrderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICommentService _commentService;
        public CommentController(IMapper mapper, ICommentService commentService) {
            _mapper = mapper;
            _commentService = commentService;
        }
        #region

        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
