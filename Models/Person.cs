using System;
using System.Collections.Generic;

namespace FreshAPI.Models
{
    public partial class Person
    {
        public Person()
        {
            Certifications = new HashSet<Certification>();
            Educations = new HashSet<Education>();
            Experiences = new HashSet<Experience>();
            Hobbies = new HashSet<Hobby>();
            Languages = new HashSet<Language>();
            References = new HashSet<Reference>();
            Skills = new HashSet<Skill>();
        }

        public string PersonId { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime? Dob { get; set; }
        public string? Country { get; set; }
        public string? ContactNumber { get; set; }
        public string? Github { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<Certification> Certifications { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<Hobby> Hobbies { get; set; }
        public virtual ICollection<Language> Languages { get; set; }
        public virtual ICollection<Reference> References { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
