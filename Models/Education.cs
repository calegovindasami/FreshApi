using System;
using System.Collections.Generic;

namespace FreshAPI.Models
{
    public partial class Education
    {
        public int EducationId { get; set; }
        public string PersonId { get; set; } = null!;
        public int StartYear { get; set; }
        public string EndYear { get; set; } = null!;
        public string QualificationType { get; set; } = null!;
        public string DegreeName { get; set; } = null!;
        public string? Summary { get; set; }

        public virtual Person Person { get; set; } = null!;
    }
}
