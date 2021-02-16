using MG.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MG.Data.Dtos.Church
{
    public class ChurchCreateDto
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        
        public string StreetAddress { get; set; }
        
        public string City { get; set; }
        
        public string Province { get; set; }
        
        [Required]
        public Country Country { get; set; }
        
        public string MixlrUrl { get; set; }
    }
}
