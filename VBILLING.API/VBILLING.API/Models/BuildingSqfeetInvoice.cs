using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class BuildingSqfeetInvoice
    {
        public long Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal Rate { get; set; }
        public decimal WidthFt { get; set; }
        public decimal WidthIn { get; set; }
        public decimal HeightFt { get; set; }
        public decimal HeightIn { get; set; }
        public decimal TotalSqfeet { get; set; }
        public long CustomerId { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public int InvoiceId { get; set; }
        public decimal? TotalSqfeetRate { get; set; }
        public int PrefixId { get; set; }
        public int SuffixItemId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual CustomerDetail Customer { get; set; } = null!;
        public virtual Prefix Prefix { get; set; } = null!;
        public virtual SuffixItem SuffixItem { get; set; } = null!;
    }
}
