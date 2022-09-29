using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class SupplyMaster
    {
        public long Id { get; set; }
        public DateTime SupplyDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int SupplyCode { get; set; }
        public long CustomerId { get; set; }
        public int MaterialId { get; set; }
        public int Qty { get; set; }
        public decimal Amount { get; set; }
        public int CompanyId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? ShippingAddress1 { get; set; }
        public string? ShippingAddress2 { get; set; }
        public string? ContactNumber { get; set; }
        public string? Lrno { get; set; }
        public decimal? LoadingCharges { get; set; }
        public decimal? UnloadingCharges { get; set; }
        public decimal? FreightCharges { get; set; }
        public decimal? ManualRate { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual CustomerDetail Customer { get; set; } = null!;
        public virtual MeterialMaster Material { get; set; } = null!;
    }
}
