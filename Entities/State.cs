using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class State
    {
        public State()
        {
            Cities = new HashSet<City>();
        }

        public long StateId { get; set; }
        public string? StateName { get; set; }
        public long? CountryId { get; set; }

        public virtual Country? Country { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
