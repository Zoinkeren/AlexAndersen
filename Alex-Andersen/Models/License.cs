using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class License
    {
        public License()
        {
            DriversHasLicenses = new HashSet<DriversHasLicense>();
        }
        [Key]
        public long LicenseId { get; set; }
        public string LicenseName { get; set; }

        public virtual ICollection<DriversHasLicense> DriversHasLicenses { get; set; }
    }
}
