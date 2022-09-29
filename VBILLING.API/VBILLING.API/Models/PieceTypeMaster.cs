using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class PieceTypeMaster
    {
        public long Id { get; set; }
        public string PieceType { get; set; } = null!;
        public bool Status { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }

        public virtual Company Company { get; set; } = null!;
    }
}
