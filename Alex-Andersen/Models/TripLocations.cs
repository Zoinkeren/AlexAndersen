using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class TripLocations
    {
        [Key]
        public int TripLocationID { get; set; }
        public bool LocationType { get; set; }

        // Foreign Key
        public ICollection<Trips> Trips { get; set; }
    }
}
