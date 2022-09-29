using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class QuotationSupplyMaster
    {
        public long Id { get; set; }
        public DateTime SupplyDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int SupplyCode { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerNumber { get; set; }
        public string? CustomerAddress { get; set; }
        public int MaterialId { get; set; }
        public int Qty { get; set; }
        public decimal Amount { get; set; }
        public int CompanyId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual MeterialMaster Material { get; set; } = null!;
    }
}
