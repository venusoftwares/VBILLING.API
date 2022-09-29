using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class TaskDetails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsCompleted { get; set; }
        public DateTime Ts { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
