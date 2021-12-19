using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class Availability
    {
        public long AvailabilityId { get; set;  }
        
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int AvailabilityStatus { get; set; }
        public long? DriverId { get; set; }

        public virtual Driver Driver { get; set; }
    }
}
