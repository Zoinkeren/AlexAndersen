using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class Status
    {
        public Status()
        {
            Trips = new HashSet<Trip>();
        }

        public long StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Trip> Trips { get; set; }
    }
}
