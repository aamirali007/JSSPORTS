using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblMainCategory
    {
        public JsTblMainCategory()
        {
            JsTblCategories = new HashSet<JsTblCategory>();
            JsTblMockups = new HashSet<JsTblMockup>();
        }

        public long MainCategoryId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public bool? IsDefault { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string? CreadtedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<JsTblCategory> JsTblCategories { get; set; }
        public virtual ICollection<JsTblMockup> JsTblMockups { get; set; }
    }
}
