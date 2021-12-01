using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class Trips
    {
        [Key]
        public int TripID { get; set; }
        [Timestamp]
        public DateTime StartDate { get; set; }
        [Timestamp]
        public DateTime EndDate { get; set; }

        public bool IsTripExpress { get; set; }
        [MaxLength(255), MinLength(10, ErrorMessage = "Beskrivelsens længde skal min. være 4")]
        public string Description { get; set; }

        // Foreign Key

        public ICollection<Departments> Departments { get; set; }
        public ICollection<Status> Statuses { get; set; }

    }
}
