using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class AttendanceDaily
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public int CompanyId { get; set; }
        public decimal Present { get; set; }
        public string? Advance { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual EmployeeDetail Employee { get; set; } = null!;
    }
}
