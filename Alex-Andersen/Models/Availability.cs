using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class Availability
    {
        public long AvailabilityId { get; set; }
        public byte[] StartDate { get; set; }
        public byte[] EndDate { get; set; }
        public byte[] AvailabilityStatus { get; set; }
        public long? DriverId { get; set; }

        public virtual Driver Driver { get; set; }
    }
}
