using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblInventoryItemCategory
    {
        public JsTblInventoryItemCategory()
        {
            JsTblInventoryItems = new HashSet<JsTblInventoryItem>();
        }

        public long ItemCategoryId { get; set; }
        public string? ItemCategoryName { get; set; }
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

        public virtual ICollection<JsTblInventoryItem> JsTblInventoryItems { get; set; }
    }
}
