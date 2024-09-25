using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblMockup
    {
        public JsTblMockup()
        {
            JsTblMockupAttachments = new HashSet<JsTblMockupAttachment>();
            JsTblMockupLogs = new HashSet<JsTblMockupLog>();
        }

        public long MockupId { get; set; }
        public string? TeamName { get; set; }
        public long? MainCategoryId { get; set; }
        public long? CategoryId { get; set; }
        public long? SubCategoryId { get; set; }
        public long? ProductId { get; set; }
        public long? FabricTypeId { get; set; }
        public long? NeckStyleId { get; set; }
        public string? FrontDescription { get; set; }
        public string? BackDescription { get; set; }
        public string? LeftSleeveDesc { get; set; }
        public string? RightSleeveDesc { get; set; }
        public bool? Active { get; set; }
        public string? Status { get; set; }
        public bool? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? UserId { get; set; }
        public string? OnlyDesc { get; set; }
        public string? MockupName { get; set; }
        public string? MockupCode { get; set; }

        public virtual JsTblCategory? Category { get; set; }
        public virtual JsTblFabricType? FabricType { get; set; }
        public virtual JsTblMainCategory? MainCategory { get; set; }
        public virtual JsTblNeckStyle? NeckStyle { get; set; }
        public virtual JsTblProduct? Product { get; set; }
        public virtual JsTblSubCategory? SubCategory { get; set; }
        public virtual JsTblUser? User { get; set; }
        public virtual ICollection<JsTblMockupAttachment> JsTblMockupAttachments { get; set; }
        public virtual ICollection<JsTblMockupLog> JsTblMockupLogs { get; set; }
    }
}
