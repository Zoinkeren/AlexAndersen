using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class Location
    {
        public Location()
        {
            TripsLocations = new HashSet<TripsLocation>();
        }

        public long LocationId { get; set; }
        public string LocationAddress { get; set; }
        public long? CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<TripsLocation> TripsLocations { get; set; }
    }
}
