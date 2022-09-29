using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class DyeingDetail
    {
        public DyeingDetail()
        {
            DyeingDetailItems = new HashSet<DyeingDetailItem>();
        }

        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long SupplierId { get; set; }
        public long? GarmentDetailId { get; set; }
        public int DyeingNo { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public decimal? Payment { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual GarmentsOrderDetail? GarmentDetail { get; set; }
        public virtual SupplierDetail Supplier { get; set; } = null!;
        public virtual ICollection<DyeingDetailItem> DyeingDetailItems { get; set; }
    }
}
