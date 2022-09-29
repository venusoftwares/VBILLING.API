using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class ShippingAddress
    {
        public int Id { get; set; }
        public long? CustomerId { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? ContactName { get; set; }
        public string? ContactNumber { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual CustomerDetail? Customer { get; set; }
    }
}
