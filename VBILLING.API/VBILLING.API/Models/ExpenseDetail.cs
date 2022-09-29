using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class ExpenseDetail
    {
        public ExpenseDetail()
        {
            ExpenseDetailItems = new HashSet<ExpenseDetailItem>();
        }

        public long Id { get; set; }
        public long? GarmentOrderDetailId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; } = null!;
        public decimal Amount { get; set; }
        public int CompanyId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual GarmentsOrderDetail? GarmentOrderDetail { get; set; }
        public virtual ICollection<ExpenseDetailItem> ExpenseDetailItems { get; set; }
    }
}
