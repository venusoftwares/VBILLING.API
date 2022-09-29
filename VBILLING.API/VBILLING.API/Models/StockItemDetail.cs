using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class StockItemDetail
    {
        public int Id { get; set; }
        public int ItemCode { get; set; }
        public decimal? OpenStock { get; set; }
        public decimal? ReminderStock { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ItemMaster ItemCodeNavigation { get; set; } = null!;
    }
}
