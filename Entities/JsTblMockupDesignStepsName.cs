using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblMockupDesignStepsName
    {
        public JsTblMockupDesignStepsName()
        {
            JsTblMockupDesignStepFromMockupDesignSteps = new HashSet<JsTblMockupDesignStep>();
            JsTblMockupDesignStepToMockupDesignSteps = new HashSet<JsTblMockupDesignStep>();
        }

        public long MockupDesignStepId { get; set; }
        public string? Name { get; set; }
        public bool? IsMockup { get; set; }
        public bool? IsDesgin { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedDate { get; set; }
        public string? ButtonDisplayName { get; set; }

        public virtual ICollection<JsTblMockupDesignStep> JsTblMockupDesignStepFromMockupDesignSteps { get; set; }
        public virtual ICollection<JsTblMockupDesignStep> JsTblMockupDesignStepToMockupDesignSteps { get; set; }
    }
}
