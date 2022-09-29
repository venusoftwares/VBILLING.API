using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class BrandDetail
    {
        public BrandDetail()
        {
            ItemMasters = new HashSet<ItemMaster>();
        }

        public int Id { get; set; }
        public string Brand { get; set; } = null!;
        public bool Status { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public decimal? Sqrate { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
    }
}
