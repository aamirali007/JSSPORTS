using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblSubCategory
    {
        public JsTblSubCategory()
        {
            JsTblMockups = new HashSet<JsTblMockup>();
            JsTblProducts = new HashSet<JsTblProduct>();
        }

        public long SubCategoryId { get; set; }
        public long? CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public bool? IsDefault { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual JsTblCategory? Category { get; set; }
        public virtual ICollection<JsTblMockup> JsTblMockups { get; set; }
        public virtual ICollection<JsTblProduct> JsTblProducts { get; set; }
    }
}
