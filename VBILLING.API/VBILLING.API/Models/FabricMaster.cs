using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class FabricMaster
    {
        public long Id { get; set; }
        public string FabricName { get; set; } = null!;
        public bool Status { get; set; }
        public int CompanyId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Company Company { get; set; } = null!;
    }
}
