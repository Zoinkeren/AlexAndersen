using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class Licenses
    {

            [Key]
            public int LicenseID { get; set; }
            [MaxLength(100)]
            public string LicenseName { get; set; }
    }
}

