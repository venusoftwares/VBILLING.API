using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class UserDetail
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? ConfirmPassword { get; set; }
        public string? OldPassword { get; set; }
        public int RoleId { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public byte[]? Image { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
    }
}
