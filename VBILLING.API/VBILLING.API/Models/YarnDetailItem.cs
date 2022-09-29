using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class YarnDetailItem
    {
        public long Id { get; set; }
        public long YarnDetailId { get; set; }
        public long YarnMasterId { get; set; }
        public decimal RatePerKg { get; set; }
        public decimal TotalKg { get; set; }
        public decimal TotalAmount { get; set; }
        public string Description { get; set; } = null!;
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public long? TempId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual YarnDetail YarnDetail { get; set; } = null!;
        public virtual YarnMaster YarnMaster { get; set; } = null!;
    }
}
