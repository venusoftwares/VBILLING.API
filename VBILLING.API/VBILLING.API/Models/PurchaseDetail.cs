using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class PurchaseDetail
    {
        public PurchaseDetail()
        {
            PurchaseDetailItems = new HashSet<PurchaseDetailItem>();
        }

        public int Id { get; set; }
        public string BillNo { get; set; } = null!;
        public DateTime BillDate { get; set; }
        public long SupplierId { get; set; }
        public string? PoNo { get; set; }
        public DateTime? PoDate { get; set; }
        public string? Transport { get; set; }
        public string? Lrno { get; set; }
        public int PaymentTermId { get; set; }
        public string? Remarks { get; set; }
        public bool WithLater { get; set; }
        public bool WithOutLater { get; set; }
        public bool Other { get; set; }
        public bool Original { get; set; }
        public bool Duplicate { get; set; }
        public bool Triplicate { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public long? GarmentsOrderDetailId { get; set; }
        public decimal? Freight { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual SupplierDetail Supplier { get; set; } = null!;
        public virtual ICollection<PurchaseDetailItem> PurchaseDetailItems { get; set; }
    }
}
