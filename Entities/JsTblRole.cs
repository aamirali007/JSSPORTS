using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblRole
    {
        public JsTblRole()
        {
            JsTblUsers = new HashSet<JsTblUser>();
        }

        public long RoleId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<JsTblUser> JsTblUsers { get; set; }
    }
}
