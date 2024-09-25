using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblOrderDesignStep
    {
        public long OrderStepsId { get; set; }
        public long? FromOrderDesignStepId { get; set; }
        public long? ToOrderDesignStepId { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDesign { get; set; }
        public bool? IsMockup { get; set; }

        public virtual JsTblOrderDesignStepsName? FromOrderDesignStep { get; set; }
        public virtual JsTblOrderDesignStepsName? ToOrderDesignStep { get; set; }
    }
}
