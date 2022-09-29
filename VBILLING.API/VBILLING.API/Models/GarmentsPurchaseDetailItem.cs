using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class GarmentsPurchaseDetailItem
    {
        public int Id { get; set; }
        public int PurchaseDetailId { get; set; }
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
        public long? StyleId { get; set; }
        public long? ColorId { get; set; }

        public virtual ColorMaster? Color { get; set; }
        public virtual StyleDetail? Style { get; set; }
    }
}
