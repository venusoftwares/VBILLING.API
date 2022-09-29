using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class EmployeeAdvance
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual EmployeeDetail Employee { get; set; } = null!;
    }
}
