using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace soccerleague.Models
{
    public partial class Players
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter a Model Description.")]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
