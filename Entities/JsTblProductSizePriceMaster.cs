using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblProductSizePriceMaster
    {
        public JsTblProductSizePriceMaster()
        {
            JsTblProductSizePriceDetails = new HashSet<JsTblProductSizePriceDetail>();
        }

        public long SizePriceHeaderId { get; set; }
        public long? ProductId { get; set; }
        public long? UserId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual JsTblProduct? Product { get; set; }
        public virtual JsTblUser? User { get; set; }
        public virtual ICollection<JsTblProductSizePriceDetail> JsTblProductSizePriceDetails { get; set; }
    }
}
