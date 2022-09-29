using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class SupplierDetail
    {
        public SupplierDetail()
        {
            DyeingDetails = new HashSet<DyeingDetail>();
            KnittingDetails = new HashSet<KnittingDetail>();
            Payments = new HashSet<Payment>();
            ProcessingDetails = new HashSet<ProcessingDetail>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            PurchaseReturnDetails = new HashSet<PurchaseReturnDetail>();
            Receipts = new HashSet<Receipt>();
            YarnDetails = new HashSet<YarnDetail>();
        }

        public long Id { get; set; }
        public string SupplierName { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public string? ContactPerson { get; set; }
        public string ContactNumber { get; set; } = null!;
        public string ShippingAddress { get; set; } = null!;
        public string? Gst { get; set; }
        public bool ActiveStatus { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<DyeingDetail> DyeingDetails { get; set; }
        public virtual ICollection<KnittingDetail> KnittingDetails { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<ProcessingDetail> ProcessingDetails { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
        public virtual ICollection<YarnDetail> YarnDetails { get; set; }
    }
}
