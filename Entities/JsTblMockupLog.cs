using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblMockupLog
    {
        public long MockupLogId { get; set; }
        public long? MockupId { get; set; }
        public long? ClientUserId { get; set; }
        public long? HostUserId { get; set; }
        public string? Status { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? LogDateTime { get; set; }

        public virtual JsTblUser? ClientUser { get; set; }
        public virtual JsTblUser? HostUser { get; set; }
        public virtual JsTblMockup? Mockup { get; set; }
    }
}
