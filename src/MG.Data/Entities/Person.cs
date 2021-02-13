using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MG.Data.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public int Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }
        public int MaritalStatus { get; set; }
        public bool IsSpeaker { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public int Country { get; set; }

        public List<Sermon> Sermons { get; set; }
    }
}
