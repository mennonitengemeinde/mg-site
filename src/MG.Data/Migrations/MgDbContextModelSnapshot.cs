﻿// <auto-generated />
using System;
using MG.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MG.Data.Migrations
{
    [DbContext(typeof(MgDbContext))]
    partial class MgDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MG.Data.Entities.Attendant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<int>("EventId")
                        .HasColumnType("integer");

                    b.Property<Guid?>("EventId1")
                        .HasColumnType("uuid");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EventId1");

                    b.ToTable("Attendants");
                });

            modelBuilder.Entity("MG.Data.Entities.Church", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<int>("Country")
                        .HasColumnType("integer");

                    b.Property<string>("MixlrUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Churches");
                });

            modelBuilder.Entity("MG.Data.Entities.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int>("AttendanceLimit")
                        .HasColumnType("integer");

                    b.Property<bool>("AttendanceSignup")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("InPerson")
                        .HasColumnType("boolean");

                    b.Property<bool>("LiveStream")
                        .HasColumnType("boolean");

                    b.Property<string>("MapSearchQuery")
                        .HasColumnType("text");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Visibility")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("MG.Data.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("text");

                    b.Property<int>("Country")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<bool>("IsSpeaker")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("integer");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.Property<string>("SecondLastName")
                        .HasColumnType("text");

                    b.Property<Guid?>("StreamId")
                        .HasColumnType("uuid");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StreamId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("MG.Data.Entities.Sermon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AudioHighUrl")
                        .HasColumnType("text");

                    b.Property<string>("AudioLowUrl")
                        .HasColumnType("text");

                    b.Property<string>("AudioMedUrl")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<int>("EventId")
                        .HasColumnType("integer");

                    b.Property<Guid?>("EventId1")
                        .HasColumnType("uuid");

                    b.Property<int>("SermonType")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("text");

                    b.Property<int>("Views")
                        .HasColumnType("integer");

                    b.Property<int>("Visibility")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EventId1");

                    b.ToTable("Sermons");
                });

            modelBuilder.Entity("MG.Data.Entities.Stream", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<int>("EventId")
                        .HasColumnType("integer");

                    b.Property<Guid?>("EventId1")
                        .HasColumnType("uuid");

                    b.Property<bool>("Live")
                        .HasColumnType("boolean");

                    b.Property<string>("LiveMixlrUrl")
                        .HasColumnType("text");

                    b.Property<string>("LiveUrl")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("Views")
                        .HasColumnType("integer");

                    b.Property<int>("Visibility")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EventId1");

                    b.ToTable("Streams");
                });

            modelBuilder.Entity("PersonSermon", b =>
                {
                    b.Property<Guid>("SermonsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SpeakersId")
                        .HasColumnType("uuid");

                    b.HasKey("SermonsId", "SpeakersId");

                    b.HasIndex("SpeakersId");

                    b.ToTable("PersonSermon");
                });

            modelBuilder.Entity("MG.Data.Entities.Attendant", b =>
                {
                    b.HasOne("MG.Data.Entities.Event", "Event")
                        .WithMany("Attendants")
                        .HasForeignKey("EventId1");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("MG.Data.Entities.Person", b =>
                {
                    b.HasOne("MG.Data.Entities.Stream", null)
                        .WithMany("Speakers")
                        .HasForeignKey("StreamId");
                });

            modelBuilder.Entity("MG.Data.Entities.Sermon", b =>
                {
                    b.HasOne("MG.Data.Entities.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId1");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("MG.Data.Entities.Stream", b =>
                {
                    b.HasOne("MG.Data.Entities.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId1");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("PersonSermon", b =>
                {
                    b.HasOne("MG.Data.Entities.Sermon", null)
                        .WithMany()
                        .HasForeignKey("SermonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MG.Data.Entities.Person", null)
                        .WithMany()
                        .HasForeignKey("SpeakersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MG.Data.Entities.Event", b =>
                {
                    b.Navigation("Attendants");
                });

            modelBuilder.Entity("MG.Data.Entities.Stream", b =>
                {
                    b.Navigation("Speakers");
                });
#pragma warning restore 612, 618
        }
    }
}