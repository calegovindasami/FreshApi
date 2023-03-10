using System;
using System.Collections.Generic;

namespace FreshAPI.Models
{
    public partial class Language
    {
        public int LanguageId { get; set; }
        public string PersonId { get; set; } = null!;
        public string LanguageName { get; set; } = null!;
        public string? Proficiency { get; set; }

        public virtual Person Person { get; set; } = null!;
    }
}
