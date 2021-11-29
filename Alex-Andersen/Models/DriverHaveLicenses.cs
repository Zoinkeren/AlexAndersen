using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class DriverHaveLicenses
    {
        [Key]
        [Column(Order = 0)]
        public int LicenseID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int DriverID { get; set; }

        public DateTime ExpirationDate { get; set; }

        // Foreign Key
        public ICollection<Licenses> Licenses { get; set; }
        public ICollection<Drivers> Drivers { get; set; }
    }
}
