using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class EmployeeInfo
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; } = null!;
        public int Salary { get; set; }
        public string DeptName { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public decimal? Hra { get; set; }
        public decimal? Ta { get; set; }
        public decimal? Da { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal? Tds { get; set; }
        public decimal? NetSalary { get; set; }
    }
}
