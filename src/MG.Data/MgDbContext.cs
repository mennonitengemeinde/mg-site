using System;
using System.Collections.Generic;
using System.Text;
using MG.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MG.Data
{
    public class MgDbContext : DbContext
    {
        public MgDbContext(DbContextOptions<MgDbContext> options) : base(options) { }

        public DbSet<Church> Churches { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendant> Attendants { get; set; }
        public DbSet<Sermon> Sermons { get; set; }
        public DbSet<Stream> Streams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}