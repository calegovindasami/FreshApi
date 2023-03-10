using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace FreshAPI.Models
{
    public partial class Hobby
    {
        public int HobbyId { get; set; }
        public string HobbyName { get; set; } = null!;
        public string PersonId { get; set; } = null!;

        
        public virtual Person Person { get; set; }
    }
}
