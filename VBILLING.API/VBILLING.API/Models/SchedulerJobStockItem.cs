using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class SchedulerJobStockItem
    {
        public long Id { get; set; }
        public int ItemCode { get; set; }
        public decimal? OpenStock { get; set; }
        public string Source { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int CompanyId { get; set; }
        public decimal? Rate { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ItemMaster ItemCodeNavigation { get; set; } = null!;
    }
}
