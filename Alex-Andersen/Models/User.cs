using System;
using System.Collections.Generic;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class User
    {
        public User()
        {
            Departments = new HashSet<Department>();
            Drivers = new HashSet<Driver>();
            UserMessages = new HashSet<UserMessage>();
        }

        public long UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public long? UserPhoneNumber { get; set; }
        public long? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<UserMessage> UserMessages { get; set; }
    }
}
