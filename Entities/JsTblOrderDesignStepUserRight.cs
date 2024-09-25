using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblOrderDesignStepUserRight
    {
        public long OrderDesignStepRightId { get; set; }
        public long? UserId { get; set; }
        public long? OrderStepsId { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedDate { get; set; }

        public virtual JsTblUser? User { get; set; }
    }
}
