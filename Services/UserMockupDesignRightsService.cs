using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportsOrderApp.DTOs;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public interface IUserMockupDesignRightsService
    {
        public IList<MockupDesignStepsUserRightsModel> GetUerMockupDesignActionRights(long userId);
    }
    public class UserMockupDesignRightsService: IUserMockupDesignRightsService
    {
        private readonly IMapper _mapper;
        private readonly IMockupDesignStepsNameRepository _mockupDesignStepsNameRepository;
        private readonly IMockupDesignStepRepository _mockupDesignStepRepository;
        private readonly IMockupDesignStepUserRightRepository _mockupDesignStepUserRightRepository;
        public UserMockupDesignRightsService(
            IMapper mapper,
            IMockupDesignStepsNameRepository mockupDesignStepsNameRepository,
            IMockupDesignStepRepository mockupDesignStepRepository,
            IMockupDesignStepUserRightRepository mockupDesignStepUserRightRepository
            )
        { 
            _mapper = mapper;
            _mockupDesignStepsNameRepository = mockupDesignStepsNameRepository;
            _mockupDesignStepRepository = mockupDesignStepRepository;
            _mockupDesignStepUserRightRepository = mockupDesignStepUserRightRepository;
        }

        public IList<MockupDesignStepsUserRightsModel> GetUerMockupDesignActionRights(long userId)
        {
            // Include MockupSteps and User navigation properties to ensure they are loaded
            //var res = _mockupDesignStepUserRightRepository.FindByQueryable(
            //              x => x.UserId == userId &&
            //              x.Deleted == false &&
            //              x.Active == true
            //      )
            //      .Include(x => x.MockupSteps)
            //      .Include(x => x.User)
            //      .ToList();

            var res = _mockupDesignStepUserRightRepository.FindBy(
                          x => x.UserId == userId &&
                          x.Deleted == false &&
                          x.Active == true
                  ).ToList();

            return _mapper.Map<List<MockupDesignStepsUserRightsModel>>(res);
        }
    }
}
