using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class KnittingDetailItem
    {
        public long Id { get; set; }
        public long KnittingDetailId { get; set; }
        public long Guage { get; set; }
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
        public virtual KnittingDetail KnittingDetail { get; set; } = null!;
    }
}
