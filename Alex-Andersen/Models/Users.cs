using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        [MaxLength(128), MinLength(6, ErrorMessage = "Brugnavnets længde skal min. være 4")]
        public string UserName { get; set; }
        [MaxLength(128), MinLength(4, ErrorMessage = "Kodeordets længde skal min. være 4")]
        public string UserPassword { get; set; }
        [MaxLength(50), MinLength(2, ErrorMessage = "Fornavns længde skal min. være 2")]
        public string FirstName { get; set; }
        [MaxLength(50), MinLength(2, ErrorMessage = "Efternavns længde skal min. være 2")]
        public string LastName { get; set; }
        [MaxLength(62), MinLength(4, ErrorMessage = "E-mail længde skal min. være 4")]
        public string UserEmail { get; set; }
        [MaxLength(15), MinLength(4, ErrorMessage = "Telefon længde skal min. være 4")]
        public int UserPhoneNumber { get; set; }

        // Foreign Key

        public ICollection<Roles> Roles { get; set; }
    }
}
