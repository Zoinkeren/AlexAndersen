using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class Locations
    {
        [Key]
        public int LocationID { get; set; }
        public string LocationAddress { get; set; }

        // foreign Key

        public ICollection<Cities> Cities { get; set; }
        public ICollection<Countries> Countries { get; set; }
    }
}
