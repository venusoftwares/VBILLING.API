using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class RolePermission
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? MenuId { get; set; }
        public int? SubMenuId { get; set; }
        public string? Privilege { get; set; }
        public int? PageId { get; set; }
        public bool? Add { get; set; }
        public bool? Edit { get; set; }
        public bool? View { get; set; }
        public bool? Delete { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Company? Company { get; set; }
        public virtual MainMenu? Menu { get; set; }
        public virtual Role? Role { get; set; }
        public virtual SubMenu? SubMenu { get; set; }
    }
}
