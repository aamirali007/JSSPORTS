using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class City
    {
        public City()
        {
            JsTblSuppliers = new HashSet<JsTblSupplier>();
        }

        public long CityId { get; set; }
        public string? CityName { get; set; }
        public long? StateId { get; set; }

        public virtual State? State { get; set; }
        public virtual ICollection<JsTblSupplier> JsTblSuppliers { get; set; }
    }
}
