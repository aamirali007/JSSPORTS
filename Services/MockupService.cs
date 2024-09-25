using AutoMapper;
using SportsOrderApp.DTOs;
using SportsOrderApp.Entities;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public interface IMockupService
    {
        public void AddNewMockup(AddNewMockup addNewMockup);
        public IList<MockupModel> GetMockupsClientRequest();
        public IList<MockupModel> MoveToDesigningDepartment();
        public IList<MockupModel> getMockupsAssignToDesigner();
        public IList<ApprovedMockupModel> GetApprovedMockups(long userId);

    }
    public class MockupService : IMockupService
    {
        private readonly IMapper _mapper;
        private readonly IMockupRepository _mockupRepository;
        private readonly IMockupAttachmentRepository _mockupAttachmentRepository;
        public MockupService(
            IMapper mapper,
            IMockupRepository mockupRepository,
            IMockupAttachmentRepository mockupAttachmentRepository
            )
        {
            _mapper = mapper;
            _mockupRepository = mockupRepository;
            _mockupAttachmentRepository = mockupAttachmentRepository;
        }

        public void AddNewMockup(AddNewMockup addNewMockup)
        {
            JsTblMockup mockup = new JsTblMockup();
            mockup.MainCategoryId = addNewMockup.MainCategoryId;
            mockup.CategoryId = addNewMockup.CategoryId;
            mockup.SubCategoryId = addNewMockup.SubCategoryId;
            mockup.ProductId = addNewMockup.ProductId;
            mockup.TeamName = addNewMockup.TeamName;
            mockup.FrontDescription = addNewMockup.FrontDescription;
            mockup.BackDescription = addNewMockup.BackDescription;
            mockup.OnlyDesc = addNewMockup.AdditionalDetail;

            mockup.Active = true;
            mockup.Deleted = false;
            mockup.Status = "CLIENT SEND";
            mockup.CreatedBy = "";

            _mockupRepository.Add(mockup);
            _mockupRepository.Commit();
            //if (mockup.MockupId > 0)
            //{
            //    JsTblMockupAttachment mockupAttachment = new JsTblMockupAttachment();
            //    if (addNewMockup.FrontImages != null)
            //    {
            //        // Save front images
            //        foreach (var frontImage in addNewMockup.FrontImages)
            //        {
            //            if (string.IsNullOrEmpty(frontImage))
            //            {
            //                // Handle null or empty image strings if necessary
            //                continue;
            //            }

            //            // Convert Base64 string to byte array
            //            byte[] imageBytes;
            //            try
            //            {
            //                imageBytes = Convert.FromBase64String(frontImage);
            //            }
            //            catch (FormatException ex)
            //            {
            //                // Handle the case when the Base64 string is not valid
            //                throw new InvalidOperationException("Invalid Base64 image format", ex);
            //            }

            //            // Check the length after conversion to bytes (in bytes, not characters)
            //            if (imageBytes.Length >= 8000)
            //            {
            //                throw new InvalidOperationException("Image size exceeds the allowed limit.");
            //            }

            //            // Assuming MockupAttachment is a new instance, otherwise instantiate it before this loop
            //            //MockupAttachment mockupAttachment = new MockupAttachment
            //            //{
            //            mockupAttachment.MockupId = mockup.MockupId;
            //            //mockupAttachment.FrontImageData = imageBytes;  // Assign byte array
            //            mockupAttachment.Side = "Front";
            //            //};

            //            // Add and commit to the repository
            //            _mockupAttachmentRepository.Add(mockupAttachment);
            //            _mockupAttachmentRepository.Commit();
            //        }
            //        if (addNewMockup.BackImages != null)
            //        {
            //            // Save front images
            //            foreach (var backImage in addNewMockup.BackImages)
            //            {
            //                mockupAttachment.MockupId = mockup.MockupId;
            //                mockupAttachment.FrontImageData = backImage;
            //                mockupAttachment.Side = "Back";
            //                _mockupAttachmentRepository.Add(mockupAttachment);
            //                _mockupAttachmentRepository.Commit();
            //            }
            //        }

            //    }




            //}
        }

        public IList<MockupModel> GetMockupsClientRequest()
        {
            var mockups = _mockupRepository.FindBy(x => x.Active == true && x.Deleted == false &&
                                            x.Status == "CLIENT SEND"
                                            ).ToList();

            return _mapper.Map<List<MockupModel>>(mockups);
        }

        public IList<MockupModel> MoveToDesigningDepartment()
        {
            var mockups = _mockupRepository.FindBy(x => x.Active == true && x.Deleted == false &&
                                            x.Status == "MOVE TO DESIGNING"
                                            ).ToList();

            return _mapper.Map<List<MockupModel>>(mockups);
        }
        public IList<MockupModel> getMockupsAssignToDesigner()
        {
            var mockups = _mockupRepository.FindBy(x => x.Active == true && x.Deleted == false &&
                                            x.Status == "ASSIGN TO DESIGNER"
                                            ).ToList();

            return _mapper.Map<List<MockupModel>>(mockups);
        }

        public IList<ApprovedMockupModel> GetApprovedMockups(long userId)
        {
            var approvedMockup = _mockupRepository.FindBy(x => x.Active == true &&
                                                    x.Deleted == false && x.UserId == userId
                                                    )
                                                   .ToList();

            return _mapper.Map<List<ApprovedMockupModel>>(approvedMockup);
        }
    }
}
