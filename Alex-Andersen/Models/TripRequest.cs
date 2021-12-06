using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class TripRequest
    {
        public long DriverId { get; set; }
        public long TripId { get; set; }

        public virtual Driver Driver { get; set; }
        public virtual Trip Trip { get; set; }
    }
}
