using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class SalaryStatement
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal Total { get; set; }
        public decimal PerDaySalary { get; set; }
        public decimal EarnAmount { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal AdvanceAmount { get; set; }
        public decimal AdvancePayments { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public int CompanyId { get; set; }
        public string? Type { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual EmployeeDetail Employee { get; set; } = null!;
    }
}
