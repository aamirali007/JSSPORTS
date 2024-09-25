using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblCategory
    {
        public JsTblCategory()
        {
            JsTblMockups = new HashSet<JsTblMockup>();
            JsTblSubCategories = new HashSet<JsTblSubCategory>();
        }

        public long CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public long? MainCategoryId { get; set; }
        public bool? IsDefault { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string? CreadtedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual JsTblMainCategory? MainCategory { get; set; }
        public virtual ICollection<JsTblMockup> JsTblMockups { get; set; }
        public virtual ICollection<JsTblSubCategory> JsTblSubCategories { get; set; }
    }
}
