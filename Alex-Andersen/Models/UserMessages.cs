using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class UserMessages
    {
        [Key]
        public int UserMessageID { get; set; }
        public bool SenderReciever { get; set; }

        // Foreign Key

        public ICollection<Users> Users { get; set; }
        public ICollection<Messages> Messages { get; set; }
    }
}
