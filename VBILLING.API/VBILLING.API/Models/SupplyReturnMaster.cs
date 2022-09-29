using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class SupplyReturnMaster
    {
        public long Id { get; set; }
        public int SupplyReturnCode { get; set; }
        public DateTime SupplyReturnDate { get; set; }
        public long CustomerId { get; set; }
        public int MaterialId { get; set; }
        public int Qty { get; set; }
        public int CompanyId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? ShippingAddress1 { get; set; }
        public string? ShippingAddress2 { get; set; }
        public string? ContactNumber { get; set; }
        public string? Lrno { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual CustomerDetail Customer { get; set; } = null!;
        public virtual MeterialMaster Material { get; set; } = null!;
    }
}
