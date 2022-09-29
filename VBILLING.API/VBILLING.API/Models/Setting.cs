using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class Setting
    {
        public int Id { get; set; }
        public bool PrintCrystalReport { get; set; }
        public bool PrintNrecoReport { get; set; }
        public int CompanyId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public bool? ProformaInvoice { get; set; }
        public bool? ProformaInvoicePayment { get; set; }
        public bool? ProformaInvoiceExpenses { get; set; }
        public bool? ProformaInvoiceStatement { get; set; }
        public string? PrintSettingsJson { get; set; }

        public virtual Company Company { get; set; } = null!;
    }
}
