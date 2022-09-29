using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class SupplyRateMaster
    {
        public long Id { get; set; }
        public long No { get; set; }
        public long CustomerId { get; set; }
        public int MaterialCode { get; set; }
        public DateTime SupplyDate { get; set; }
        public DateTime SupplyReturnDate { get; set; }
        public long SupplyCode { get; set; }
        public long SupplyReturnCode { get; set; }
        public int Qty { get; set; }
        public int TotalDays { get; set; }
        public decimal PerDayRate { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal Amount { get; set; }
        public int CompanyId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual CustomerDetail Customer { get; set; } = null!;
    }
}
