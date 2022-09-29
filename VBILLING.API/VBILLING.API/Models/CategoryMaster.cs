using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class CategoryMaster
    {
        public CategoryMaster()
        {
            EmployeeDetails = new HashSet<EmployeeDetail>();
        }

        public long Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public int CompanyId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? Status { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<EmployeeDetail> EmployeeDetails { get; set; }
    }
}
