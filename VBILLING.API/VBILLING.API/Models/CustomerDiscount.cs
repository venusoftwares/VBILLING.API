﻿using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class CustomerDiscount
    {
        public long Id { get; set; }
        public long CustomerCode { get; set; }
        public DateTime DiscountDate { get; set; }
        public decimal Amount { get; set; }
        public int ConCode { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Company ConCodeNavigation { get; set; } = null!;
        public virtual CustomerDetail CustomerCodeNavigation { get; set; } = null!;
    }
}
