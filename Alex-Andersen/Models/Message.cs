using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class Message
    {
        public Message()
        {
            UserMessages = new HashSet<UserMessage>();
        }

        public long MessageId { get; set; }
        public string MessageTitle { get; set; }
        public string MessageDescription { get; set; }
        public byte[] IsMessageRead { get; set; }

        public virtual ICollection<UserMessage> UserMessages { get; set; }
    }
}
