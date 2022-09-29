using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class CustomerAdvance
    {
        public long Id { get; set; }
        public long CustomerCode { get; set; }
        public DateTime AdvanceDate { get; set; }
        public decimal Amount { get; set; }
        public int ConCode { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? Code { get; set; }

        public virtual Company ConCodeNavigation { get; set; } = null!;
        public virtual CustomerDetail CustomerCodeNavigation { get; set; } = null!;
    }
}
