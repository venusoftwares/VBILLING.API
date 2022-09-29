using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class MeterialMaster
    {
        public MeterialMaster()
        {
            QuotationSupplyMasters = new HashSet<QuotationSupplyMaster>();
            SupplyMasters = new HashSet<SupplyMaster>();
            SupplyReturnMasters = new HashSet<SupplyReturnMaster>();
        }

        public int Id { get; set; }
        public string MaterialName { get; set; } = null!;
        public int MaterialCode { get; set; }
        public decimal Rate { get; set; }
        public int CompanyId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal? OpenStock { get; set; }
        public decimal? ReminderStock { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<QuotationSupplyMaster> QuotationSupplyMasters { get; set; }
        public virtual ICollection<SupplyMaster> SupplyMasters { get; set; }
        public virtual ICollection<SupplyReturnMaster> SupplyReturnMasters { get; set; }
    }
}
