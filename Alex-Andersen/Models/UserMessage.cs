using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class UserMessage
    {
        public long UserMessagesId { get; set; }
        public byte[] SenderReciever { get; set; }
        public long? UserId { get; set; }
        public long? MesssageId { get; set; }

        public virtual Message Messsage { get; set; }
        public virtual User User { get; set; }
    }
}
