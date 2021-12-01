using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class Roles
    {
        [Key]
        public int RoleID { get; set; }
        [MaxLength(15)]
        public string RoleName { get; set; }
    }
}
