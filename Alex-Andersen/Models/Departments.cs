using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class Departments
    {
        [Key]
        public int DepartmentID { get; set; }
        [MaxLength(200)]
        public string DepartmentName { get; set; }
        [MaxLength(200)]
        public string DepartmentAddress { get; set; }

        // Foreign Key

        public ICollection<Cities> Cities { get; set; }
        public ICollection<Users> Users { get; set; }
        public ICollection<Countries> Countries { get; set; }
    }
}
