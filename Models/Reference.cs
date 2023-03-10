using System;
using System.Collections.Generic;

namespace FreshAPI.Models
{
    public partial class Reference
    {
        public int ReferenceId { get; set; }
        public string PersonId { get; set; } = null!;
        public string? Email { get; set; }
        public string? ContactNumber { get; set; }
        public string? CompanyName { get; set; }

        public virtual Person Person { get; set; } = null!;
    }
}
