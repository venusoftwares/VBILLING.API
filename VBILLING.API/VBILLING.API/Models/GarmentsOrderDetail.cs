using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class GarmentsOrderDetail
    {
        public GarmentsOrderDetail()
        {
            DyeingDetails = new HashSet<DyeingDetail>();
            ExpenseDetails = new HashSet<ExpenseDetail>();
            GarmentsOrderDetailItems = new HashSet<GarmentsOrderDetailItem>();
            KnittingDetails = new HashSet<KnittingDetail>();
            Payments = new HashSet<Payment>();
            ProcessingDetails = new HashSet<ProcessingDetail>();
            YarnDetails = new HashSet<YarnDetail>();
        }

        public long Id { get; set; }
        public long OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DueDate { get; set; }
        public long CustomerId { get; set; }
        public int CompanyId { get; set; }
        public string? ShippingAddress1 { get; set; }
        public string? ShippingAddress2 { get; set; }
        public decimal? FreightCost { get; set; }
        public string? FreightDescription { get; set; }
        public decimal? OtherExpenses { get; set; }
        public string? Lrno { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public bool ClosedStatus { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual CustomerDetail Customer { get; set; } = null!;
        public virtual ICollection<DyeingDetail> DyeingDetails { get; set; }
        public virtual ICollection<ExpenseDetail> ExpenseDetails { get; set; }
        public virtual ICollection<GarmentsOrderDetailItem> GarmentsOrderDetailItems { get; set; }
        public virtual ICollection<KnittingDetail> KnittingDetails { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<ProcessingDetail> ProcessingDetails { get; set; }
        public virtual ICollection<YarnDetail> YarnDetails { get; set; }
    }
}
