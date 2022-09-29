using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class User
    {
        public User()
        {
            RefreshTokens = new HashSet<RefreshToken>();
            TaskDetails = new HashSet<TaskDetails>();
        }

        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string PasswordSalt { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime Ts { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
        public virtual ICollection<TaskDetails> TaskDetails { get; set; }
    }
}
