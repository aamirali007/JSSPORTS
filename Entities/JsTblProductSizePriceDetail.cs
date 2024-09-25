using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblProductSizePriceDetail
    {
        public long SizePriceId { get; set; }
        public long? SizePriceHeaderId { get; set; }
        public long? ProductSizeId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Discount { get; set; }
        public bool? Active { get; set; }
        public long? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual JsTblProductSizeList? ProductSize { get; set; }
        public virtual JsTblProductSizePriceMaster? SizePriceHeader { get; set; }
    }
}
