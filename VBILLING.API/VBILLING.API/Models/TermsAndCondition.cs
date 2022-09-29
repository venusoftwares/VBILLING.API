using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class TermsAndCondition
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public DateTime Date { get; set; }
        public string SalesTax { get; set; } = null!;
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; } = null!;
    }
}
