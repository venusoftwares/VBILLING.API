using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class ProcessMaster
    {
        public ProcessMaster()
        {
            ProcessingDetailItems = new HashSet<ProcessingDetailItem>();
        }

        public long Id { get; set; }
        public string ProcessName { get; set; } = null!;
        public bool Status { get; set; }
        public int CompanyId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<ProcessingDetailItem> ProcessingDetailItems { get; set; }
    }
}
