using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class TypePreference
    {
        public TypePreference()
        {
            Drivers = new HashSet<Driver>();
        }

        public long TypePreferenceId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Driver> Drivers { get; set; }
    }
}
