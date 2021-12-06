using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class DriversHasLicense
    {
        public byte[] ExpirationDate { get; set; }
        public long LicenseId { get; set; }
        public long DriverId { get; set; }

        public virtual Driver Driver { get; set; }
        public virtual License License { get; set; }
    }
}
