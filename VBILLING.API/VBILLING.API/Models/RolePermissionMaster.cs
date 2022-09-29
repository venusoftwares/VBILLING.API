using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class RolePermissionMaster
    {
        public long Id { get; set; }
        public int RoleId { get; set; }
        public int PageId { get; set; }
        public bool? Add { get; set; }
        public bool? Edit { get; set; }
        public bool? View { get; set; }
        public bool? Delete { get; set; }
        public int? CompanyId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
