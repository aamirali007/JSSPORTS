using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblMockupAttachment
    {
        public long MockupAttachmentId { get; set; }
        public long? MockupId { get; set; }
        public string? Side { get; set; }
        public string? FrontImageData { get; set; }
        public string? BackImageData { get; set; }
        public string? FrontImagePath { get; set; }
        public string? BackImagePath { get; set; }
        public string? LeftSleeveImageData { get; set; }
        public string? LeftSleeveImagePath { get; set; }
        public string? RightSleeveImageData { get; set; }
        public string? RightSleeveImagePath { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual JsTblMockup? Mockup { get; set; }
    }
}
