using SportsOrderApp.Entities;

namespace SportsOrderApp.DTOs
{
    public class MockupDesignStepsNameModel
    {
        public long MockupDesignStepId { get; set; }
        public string? Name { get; set; }
        public string? ButtonDisplayName { get; set; }
        public bool? IsMockup { get; set; }
        public bool? IsDesgin { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
    }

    public class MockupDesignStepsModel
    {
        public long MockupStepsId { get; set; }
        public long? FromMockupDesignStepId { get; set; }
        public long? ToMockupDesignStepId { get; set; }
        public bool? IsMockup { get; set; }
        public bool? IsDesign { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public MockupDesignStepsNameModel? FromMockupDesignStep { get; set; }
        public MockupDesignStepsNameModel? ToMockupDesignStep { get; set; }
    }

    public class MockupDesignStepsUserRightsModel
    {
        public long MockupDesignStepRightId { get; set; }
        public long? UserId { get; set; }
        public long? MockupStepsId { get; set; }

        public MockupDesignStepsModel? MockupSteps { get; set; }
        public UserModel? User { get; set; }
    }
}
