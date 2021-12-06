using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class Driver
    {
        public Driver()
        {
            Availabilities = new HashSet<Availability>();
            DriversHasLicenses = new HashSet<DriversHasLicense>();
            TripHasDrivers = new HashSet<TripHasDriver>();
            TripRequests = new HashSet<TripRequest>();
        }

        public long DriverId { get; set; }
        public string ImageFile { get; set; }
        public byte[] IsDriverActive { get; set; }
        public string DriverResidence { get; set; }
        public long? UserId { get; set; }
        public long? CountryId { get; set; }
        public long? TypePreferenceId { get; set; }
        public long? CityId { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual TypePreference TypePreference { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Availability> Availabilities { get; set; }
        public virtual ICollection<DriversHasLicense> DriversHasLicenses { get; set; }
        public virtual ICollection<TripHasDriver> TripHasDrivers { get; set; }
        public virtual ICollection<TripRequest> TripRequests { get; set; }
    }
}
