using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class SuffixItem
    {
        public SuffixItem()
        {
            BuildingSqfeetInvoices = new HashSet<BuildingSqfeetInvoice>();
        }

        public int Id { get; set; }
        public string DsuffixItem { get; set; } = null!;
        public bool Status { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public decimal Sqrate { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<BuildingSqfeetInvoice> BuildingSqfeetInvoices { get; set; }
    }
}
