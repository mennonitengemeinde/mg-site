using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.EntityFrameworkCore;

using MG.Data.Enums;
using MG.Data.Entities;

namespace MG.Data
{
    public class SampleData
    {
        public static void Initialize(IDbContextFactory<MgDbContext> contextFactory)
        {
            using var context = contextFactory.CreateDbContext();

            context.Database.EnsureCreated();

            if (context.Churches.Any())
            {
                return;
            }

            var churches = new Church[]
            {
                    new Church { Id = Guid.NewGuid(), Name = "Church 1", StreetAddress = "123 Street", City = "Detroit", Province = "Michigan", Country = (int)Country.US },
                    new Church { Id = Guid.NewGuid(), Name = "Church 2", StreetAddress = "231 Street", City = "Ann Arbour", Province = "Michigan", Country = (int)Country.US },
                    new Church { Id = Guid.NewGuid(), Name = "Church 3", StreetAddress = "321 Street", City = "Taylor", Province = "Michigan", Country = (int)Country.US }
            };
            context.Churches.AddRange(churches);
            context.SaveChanges();

            var people = new Person[]
            {
                    new Person { Id = Guid.NewGuid(), FirstName = "Daniel", LastName = "Norg", SecondLastName = "Taiber", Gender = (int)Gender.Male, DateOfBirth = new DateTime(1981, 12, 31), ContactNumber = "123-456-7890", MaritalStatus = (int)MaritalStatus.Single, IsSpeaker = true, StreetAddress = "123 Street", City = "Detroit", Province = "Michigan", Country = (int)Country.US }
            };
            context.People.AddRange(people);
            context.SaveChanges();

            var events = new Event[]
            {
                    new Event { Id = Guid.NewGuid(), Title = "Event 1", Start = DateTime.Now, End = DateTime.Now.Add(new TimeSpan(1, 30, 0)), Description = "New Event", Address = $"123 Street, Detroit, Michigan, ${Country.US.ToString()}", MapSearchQuery = "Church 1", InPerson = true, LiveStream = true, AttendanceLimit = 10, AttendanceSignup = true, Visibility = (int)Visibility.Public }
            };
            context.Events.AddRange(events);
            context.SaveChanges();
        }
    }
}
