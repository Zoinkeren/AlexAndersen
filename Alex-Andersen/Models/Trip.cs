using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class Trip
    {
        public Trip()
        {
            TripHasDrivers = new HashSet<TripHasDriver>();
            TripRequests = new HashSet<TripRequest>();
            TripsLocations = new HashSet<TripsLocation>();
        }

        public long TripId { get; set; }
        public byte[] StartDate { get; set; }
        public byte[] EndDate { get; set; }
        public string Description { get; set; }
        public byte[] IsTripExpress { get; set; }
        public long? DepartmentId { get; set; }
        public long? StatusId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<TripHasDriver> TripHasDrivers { get; set; }
        public virtual ICollection<TripRequest> TripRequests { get; set; }
        public virtual ICollection<TripsLocation> TripsLocations { get; set; }
    }
}
