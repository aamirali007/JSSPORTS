using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblInventoryItem
    {
        public long ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? Description { get; set; }
        public long? ItemCategoryId { get; set; }
        public string? Sku { get; set; }
        public string? Upc { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? SellingPrice { get; set; }
        public decimal? Weight { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public string? Dimensions { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public int? Attribute1 { get; set; }
        public int? Attribute2 { get; set; }
        public int? Attribute3 { get; set; }
        public int? Attribute4 { get; set; }
        public int? Attribute5 { get; set; }
        public string? Attribute6 { get; set; }
        public string? Attribute7 { get; set; }
        public string? Attribute8 { get; set; }
        public string? Attribute9 { get; set; }
        public string? Attribute10 { get; set; }
        public bool? Attribute11 { get; set; }
        public bool? Attribute12 { get; set; }
        public bool? Attribute13 { get; set; }
        public bool? Attribute14 { get; set; }
        public bool? Attribute15 { get; set; }

        public virtual JsTblInventoryItemCategory? ItemCategory { get; set; }
    }
}
