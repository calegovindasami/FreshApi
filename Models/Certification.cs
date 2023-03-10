using System;
using System.Collections.Generic;

namespace FreshAPI.Models
{
    public partial class Certification
    {
        public int CertificationId { get; set; }
        public string PersonId { get; set; } = null!;
        public string CertificationName { get; set; } = null!;

        public virtual Person Person { get; set; } = null!;
    }
}
