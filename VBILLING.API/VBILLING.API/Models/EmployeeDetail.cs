using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class EmployeeDetail
    {
        public EmployeeDetail()
        {
            AttendanceDailies = new HashSet<AttendanceDaily>();
            EmployeeAdvancePayments = new HashSet<EmployeeAdvancePayment>();
            EmployeeAdvances = new HashSet<EmployeeAdvance>();
            SalaryStatements = new HashSet<SalaryStatement>();
        }

        public long Id { get; set; }
        public string EmpName { get; set; } = null!;
        public string EmpNumber { get; set; } = null!;
        public string? EmployeeType { get; set; }
        public DateTime Dob { get; set; }
        public decimal PerDaySalary { get; set; }
        public DateTime Doj { get; set; }
        public decimal AdvanceLimit { get; set; }
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public string FatherName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public long CategoryId { get; set; }
        public long DepartmentId { get; set; }
        public long DesignationId { get; set; }
        public DateTime? Dor { get; set; }
        public bool Relieve { get; set; }
        public string WeekOff { get; set; } = null!;
        public int CompanyId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? Status { get; set; }
        public string? ContactNumber { get; set; }

        public virtual CategoryMaster Category { get; set; } = null!;
        public virtual DepartmentMaster Department { get; set; } = null!;
        public virtual DesignationMaster Designation { get; set; } = null!;
        public virtual ICollection<AttendanceDaily> AttendanceDailies { get; set; }
        public virtual ICollection<EmployeeAdvancePayment> EmployeeAdvancePayments { get; set; }
        public virtual ICollection<EmployeeAdvance> EmployeeAdvances { get; set; }
        public virtual ICollection<SalaryStatement> SalaryStatements { get; set; }
    }
}
