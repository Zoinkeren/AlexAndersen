using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class TripsLocation
    {
        public long TripsLocationsId { get; set; }
        public byte[] LocationEndpoint { get; set; }
        public long? TripId { get; set; }
        public long? LocationId { get; set; }

        public virtual Location Location { get; set; }
        public virtual Trip Trip { get; set; }
    }
}
