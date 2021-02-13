using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MG.Data.Entities
{
    public class Stream
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public string LiveUrl { get; set; }
        public string LiveMixlrUrl { get; set; }
        public bool Live { get; set; }
        public int Visibility { get; set; }
        public int Views { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        public List<Person> Speakers { get; set; }
    }
}
