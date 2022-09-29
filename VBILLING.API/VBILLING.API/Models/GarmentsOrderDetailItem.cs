using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class GarmentsOrderDetailItem
    {
        public GarmentsOrderDetailItem()
        {
            OrderWisePurchaseDetails = new HashSet<OrderWisePurchaseDetail>();
            PieceRateMasters = new HashSet<PieceRateMaster>();
            WorkEntryDetails = new HashSet<WorkEntryDetail>();
        }

        public long Id { get; set; }
        public long GarmentsOrderDetailId { get; set; }
        public long StyleId { get; set; }
        public long ColorId { get; set; }
        public decimal PricePerPiece { get; set; }
        public decimal Qty { get; set; }
        public decimal TotalAmount { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public long? TempId { get; set; }
        public string? PieceRateJson { get; set; }

        public virtual ColorMaster Color { get; set; } = null!;
        public virtual Company Company { get; set; } = null!;
        public virtual GarmentsOrderDetail GarmentsOrderDetail { get; set; } = null!;
        public virtual StyleDetail Style { get; set; } = null!;
        public virtual ICollection<OrderWisePurchaseDetail> OrderWisePurchaseDetails { get; set; }
        public virtual ICollection<PieceRateMaster> PieceRateMasters { get; set; }
        public virtual ICollection<WorkEntryDetail> WorkEntryDetails { get; set; }
    }
}
