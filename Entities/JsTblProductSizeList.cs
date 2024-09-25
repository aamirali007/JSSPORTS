using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblProductSizeList
    {
        public JsTblProductSizeList()
        {
            JsTblProductSizePriceDetails = new HashSet<JsTblProductSizePriceDetail>();
        }

        public long ProductSizeId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public bool? IsOverSize { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<JsTblProductSizePriceDetail> JsTblProductSizePriceDetails { get; set; }
    }
}
