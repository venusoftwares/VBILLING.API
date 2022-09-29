using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class MainMenu
    {
        public MainMenu()
        {
            RolePermissions = new HashSet<RolePermission>();
        }

        public int Id { get; set; }
        public string Menu { get; set; } = null!;
        public int CompanyId { get; set; }
        public int SortOrder { get; set; }
        public bool? Status { get; set; }
        public string? Icon { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
