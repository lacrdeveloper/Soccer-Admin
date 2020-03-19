using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace soccerleague.Models
{
    public partial class Players
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
        public string Image { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
