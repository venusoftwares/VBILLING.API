using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class DashboardMaster
    {
        public int Id { get; set; }
        public string? Dashboard { get; set; }
        public int? CompanyId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
