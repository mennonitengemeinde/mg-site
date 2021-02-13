using System;
using System.Collections.Generic;
using System.Text;

namespace MG.Data.Entities
{
    public class Attendant
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public int Amount { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
