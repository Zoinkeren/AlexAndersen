using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class Availability
    {
        [Key]
        public int AvailabilityID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool AvailabilityStatus { get; set; }

        // Foreign Key

        public ICollection<Drivers> drivers { get; set; }

    }
}
