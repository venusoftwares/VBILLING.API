using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class OrderWisePurchaseDetail
    {
        public long Id { get; set; }
        public long OrderDetailItemId { get; set; }
        public string PurchaseJson { get; set; } = null!;
        public DateTime Date { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual GarmentsOrderDetailItem OrderDetailItem { get; set; } = null!;
    }
}
