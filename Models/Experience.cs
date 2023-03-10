using System;
using System.Collections.Generic;

namespace FreshAPI.Models
{
    public partial class Experience
    {
        public int ExperienceId { get; set; }
        public string PersonId { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public int StartYear { get; set; }
        public string EndYear { get; set; } = null!;
        public string JobTitle { get; set; } = null!;
        public string? Summary { get; set; }

        public virtual Person Person { get; set; } = null!;
    }
}
