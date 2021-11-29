using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class TripsHasDrivers
    {

        [Key] 
        [Column(Order = 0)] 
        public int DriverID { get; set; }

        [Key] 
        [Column(Order = 1)] 
        public int TripID { get; set; }   
        

        // Foreign Key
        public ICollection<Trips> Trips { get; set; }
        public ICollection<Drivers> Drivers { get; set; }
    }
}
