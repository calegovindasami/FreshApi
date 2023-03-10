using System;
using System.Collections.Generic;

namespace FreshAPI.Models
{
    public partial class Skill
    {
        public int SkillId { get; set; }
        public string PersonId { get; set; } = null!;
        public string SkillName { get; set; } = null!;

        public virtual Person Person { get; set; } = null!;
    }
}
