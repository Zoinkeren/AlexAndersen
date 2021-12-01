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
        [MaxLength(45), MinLength(1, ErrorMessage ="There must be a title")]
        public string MessageTitle { get; set; }
        [MaxLength(500)]
        public string MessageDescription { get; set; }
        public bool IsMessageRead { get; set; }
    }
}
