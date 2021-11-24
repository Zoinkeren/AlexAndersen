using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class Messages
    {
        [Key]
        public int MessageID { get; set; }
        public string MessageTitle { get; set; }
        public string MessageDescription { get; set; }
        public bool IsMessageRead { get; set; }
    }
}
