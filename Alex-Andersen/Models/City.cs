using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class City
    {
        public City()
        {
            Departments = new HashSet<Department>();
            Drivers = new HashSet<Driver>();
            Locations = new HashSet<Location>();
        }

        public long CityId { get; set; }
        public string CityName { get; set; }
        public long? CountryId { get; set; }
        public long? Zip { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
