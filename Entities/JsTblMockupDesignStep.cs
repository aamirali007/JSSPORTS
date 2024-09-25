using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblMockupDesignStep
    {
        public JsTblMockupDesignStep()
        {
            JsTblMockupDesignStepUserRights = new HashSet<JsTblMockupDesignStepUserRight>();
        }

        public long MockupStepsId { get; set; }
        public long? FromMockupDesignStepId { get; set; }
        public long? ToMockupDesignStepId { get; set; }
        public bool? IsMockup { get; set; }
        public bool? IsDesign { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual JsTblMockupDesignStepsName? FromMockupDesignStep { get; set; }
        public virtual JsTblMockupDesignStepsName? ToMockupDesignStep { get; set; }
        public virtual ICollection<JsTblMockupDesignStepUserRight> JsTblMockupDesignStepUserRights { get; set; }
    }
}
