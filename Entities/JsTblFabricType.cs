using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblFabricType
    {
        public JsTblFabricType()
        {
            JsTblMockups = new HashSet<JsTblMockup>();
        }

        public long FabricTypeId { get; set; }
        public string? FabricTypeName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<JsTblMockup> JsTblMockups { get; set; }
    }
}
