using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class ProcessingDetail
    {
        public ProcessingDetail()
        {
            ProcessingDetailItems = new HashSet<ProcessingDetailItem>();
        }

        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long SupplierId { get; set; }
        public long? GarmentDetailId { get; set; }
        public int ProcessNo { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public decimal? Payment { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual GarmentsOrderDetail? GarmentDetail { get; set; }
        public virtual SupplierDetail Supplier { get; set; } = null!;
        public virtual ICollection<ProcessingDetailItem> ProcessingDetailItems { get; set; }
    }
}
