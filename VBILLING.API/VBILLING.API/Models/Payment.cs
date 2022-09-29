using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public string? PaymentType { get; set; }
        public string? BankName { get; set; }
        public int VocherNo { get; set; }
        public DateTime Date { get; set; }
        public string? Account { get; set; }
        public string? BillNo { get; set; }
        public DateTime? PaymentReminderDate { get; set; }
        public decimal Amount { get; set; }
        public string? ChequeNo { get; set; }
        public string? ChequeType { get; set; }
        public string? Narration { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int CompanyId { get; set; }
        public long? CustomerId { get; set; }
        public long? SupplierId { get; set; }
        public string? Description { get; set; }
        public long? GarmentOrderDetailId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual CustomerDetail? Customer { get; set; }
        public virtual GarmentsOrderDetail? GarmentOrderDetail { get; set; }
        public virtual SupplierDetail? Supplier { get; set; }
    }
}
