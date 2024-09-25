using AutoMapper;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public interface IMockupAttachmentService
    {

    }
    public class MockupAttachmentService: IMockupAttachmentService
    {
        private readonly IMapper _mapper;
        private readonly IMockupAttachmentRepository _mockupAttachmentRepository;
        public MockupAttachmentService(IMapper mapper, IMockupAttachmentRepository mockupAttachmentRepository) 
        {
            _mapper = mapper;
            _mockupAttachmentRepository = mockupAttachmentRepository;
        }
    }
}
