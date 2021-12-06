using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
            Drivers = new HashSet<Driver>();
        }

        public long CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string PhoneCode { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
    }
}
