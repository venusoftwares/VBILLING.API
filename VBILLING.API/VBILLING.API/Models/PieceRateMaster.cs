using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class PieceRateMaster
    {
        public long Id { get; set; }
        public long OrderDetailItemId { get; set; }
        public long PieceTypeId { get; set; }
        public decimal PieceRate { get; set; }
        public decimal Qty { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual GarmentsOrderDetailItem OrderDetailItem { get; set; } = null!;
    }
}
