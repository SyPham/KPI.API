using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace API.Models
{
    public class User : IdentityUser<int>
    {
        public User()
        {
            CreatedTime = DateTime.Now;
        }
        public DateTime CreatedTime { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}