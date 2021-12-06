using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class Department
    {
        public Department()
        {
            Trips = new HashSet<Trip>();
        }

        public long DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentAddress { get; set; }
        public long? CityId { get; set; }
        public long? UserId { get; set; }

        public virtual City City { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Trip> Trips { get; set; }
    }
}
