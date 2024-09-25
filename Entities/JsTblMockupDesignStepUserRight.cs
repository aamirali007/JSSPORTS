using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblMockupDesignStepUserRight
    {
        public long MockupDesignStepRightId { get; set; }
        public long? UserId { get; set; }
        public long? MockupStepsId { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual JsTblMockupDesignStep? MockupSteps { get; set; }
        public virtual JsTblUser? User { get; set; }
    }
}
