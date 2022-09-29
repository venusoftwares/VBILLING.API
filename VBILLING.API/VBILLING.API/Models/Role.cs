using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class Role
    {
        public Role()
        {
            RolePermissions = new HashSet<RolePermission>();
            UserDetails = new HashSet<UserDetail>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; } = null!;
        public bool Status { get; set; }
        public string Dashboard { get; set; } = null!;
        public int CompanyId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}
