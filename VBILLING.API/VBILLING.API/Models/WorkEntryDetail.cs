﻿using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class WorkEntryDetail
    {
        public long Id { get; set; }
        public long OrderDetailItemId { get; set; }
        public long EmployeeId { get; set; }
        public string? WorkJson { get; set; }
        public DateTime Date { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual GarmentsOrderDetailItem OrderDetailItem { get; set; } = null!;
    }
}
