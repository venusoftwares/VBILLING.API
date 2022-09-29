using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class NewRegistration
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public string PhoneNo { get; set; } = null!;
        public string? BusinessType { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
