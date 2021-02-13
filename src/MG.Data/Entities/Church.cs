using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MG.Data.Entities
{
    public class Church
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public int Country { get; set; }
        public string MixlrUrl { get; set; }
    }
}
