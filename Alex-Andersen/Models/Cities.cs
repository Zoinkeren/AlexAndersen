using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class Cities
    {
        [Key]
        public int CityID { get; set; }
        [MaxLength(50)]
        public string CityName { get; set; }
        public int CityZip { get; set; }

        // Foreign Key

        public ICollection<Countries> Countries { get; set; }
    }
}
