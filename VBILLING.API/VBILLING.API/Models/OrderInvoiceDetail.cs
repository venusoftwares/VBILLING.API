using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class OrderInvoiceDetail
    {
        public int Id { get; set; }
        public int BillNo { get; set; }
        public DateTime BillDate { get; set; }
        public long CustomerId { get; set; }
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
        public string? InvoiceType { get; set; }
        public long? InvoiceId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual CustomerDetail Customer { get; set; } = null!;
    }
}
