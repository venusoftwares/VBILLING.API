using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class SubMenu
    {
        public SubMenu()
        {
            RolePermissions = new HashSet<RolePermission>();
        }

        public int Id { get; set; }
        public string SubMenu1 { get; set; } = null!;
        public string ControllerName { get; set; } = null!;
        public string Action { get; set; } = null!;
        public int SortNo { get; set; }
        public int CompanyId { get; set; }
        public bool? Status { get; set; }
        public string? Icon { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
