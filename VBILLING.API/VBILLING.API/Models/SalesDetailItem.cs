using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class SalesDetailItem
    {
        public int Id { get; set; }
        public int SalesDetailId { get; set; }
        public int MaterialId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public int UnitId { get; set; }
        public int TaxId { get; set; }
        public decimal Sgst { get; set; }
        public decimal Cgst { get; set; }
        public decimal? Discount { get; set; }
        public decimal Amount { get; set; }
        public string? HsnCode { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? TempId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ItemMaster Material { get; set; } = null!;
        public virtual SalesDetail SalesDetail { get; set; } = null!;
        public virtual TaxSetting Tax { get; set; } = null!;
        public virtual UnitMeasurement Unit { get; set; } = null!;
    }
}
