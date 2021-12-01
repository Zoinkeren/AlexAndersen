using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class Drivers
    {
        [Key]
        public int DriverId { get; set; }
        [MaxLength(200)]
        public string DriverResidence { get; set; }
        // public string Image_file { get; set; }
        public bool IsDriverActive { get; set; }

        // Foreign Keys
        public ICollection<TypePreferences> TypePreferences { get; set; }
        public ICollection<Countries> Countries{ get; set; }
        public ICollection<Cities> Cities { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
