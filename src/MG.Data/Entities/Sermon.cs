using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MG.Data.Entities
{
    public class Sermon
    {
        public Guid Id { get; set; }
        public int SermonType { get; set; }
        [Required]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public string AudioLowUrl { get; set; }
        public string AudioMedUrl { get; set; }
        public string AudioHighUrl { get; set; }
        public string VideoUrl { get; set; }
        public int Visibility { get; set; }
        public int Views { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        public List<Person> Speakers { get; set; }
    }
}
