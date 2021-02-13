using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MG.Data.Entities
{
    public class Event
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public string Address { get; set; }
        public string MapSearchQuery { get; set; }

        public bool InPerson { get; set; }
        public bool LiveStream { get; set; }
        public int AttendanceLimit { get; set; }
        public bool AttendanceSignup { get; set; }
        public int Visibility { get; set; }

        public List<Attendant> Attendants { get; set; }
    }
}
