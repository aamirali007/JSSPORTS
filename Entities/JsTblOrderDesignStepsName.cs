using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblOrderDesignStepsName
    {
        public JsTblOrderDesignStepsName()
        {
            JsTblOrderDesignStepFromOrderDesignSteps = new HashSet<JsTblOrderDesignStep>();
            JsTblOrderDesignStepToOrderDesignSteps = new HashSet<JsTblOrderDesignStep>();
        }

        public long OrderDesignStepId { get; set; }
        public string? Name { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ButtonDisplayName { get; set; }
        public bool? IsMockup { get; set; }
        public bool? IsDesgin { get; set; }

        public virtual ICollection<JsTblOrderDesignStep> JsTblOrderDesignStepFromOrderDesignSteps { get; set; }
        public virtual ICollection<JsTblOrderDesignStep> JsTblOrderDesignStepToOrderDesignSteps { get; set; }
    }
}
