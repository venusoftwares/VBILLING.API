using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class ColorMaster
    {
        public ColorMaster()
        {
            GarmentsOrderDetailItems = new HashSet<GarmentsOrderDetailItem>();
            GarmentsPurchaseDetailItems = new HashSet<GarmentsPurchaseDetailItem>();
        }

        public long Id { get; set; }
        public string Colors { get; set; } = null!;
        public bool Status { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<GarmentsOrderDetailItem> GarmentsOrderDetailItems { get; set; }
        public virtual ICollection<GarmentsPurchaseDetailItem> GarmentsPurchaseDetailItems { get; set; }
    }
}
