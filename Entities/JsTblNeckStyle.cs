using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblNeckStyle
    {
        public JsTblNeckStyle()
        {
            JsTblMockups = new HashSet<JsTblMockup>();
        }

        public long NeckStyleId { get; set; }
        public string? NeckStyleName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<JsTblMockup> JsTblMockups { get; set; }
    }
}
