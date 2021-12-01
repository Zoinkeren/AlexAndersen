using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class TypePreferences
    {
        [Key]
        public int TypePreferenceID { get; set; }
        [MaxLength(50)]
        public string TypeName { get; set; }
    }
}
