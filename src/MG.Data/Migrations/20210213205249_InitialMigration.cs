using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MG.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Churches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    StreetAddress = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Province = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<int>(type: "integer", nullable: false),
                    MixlrUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Churches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    MapSearchQuery = table.Column<string>(type: "text", nullable: true),
                    InPerson = table.Column<bool>(type: "boolean", nullable: false),
                    LiveStream = table.Column<bool>(type: "boolean", nullable: false),
                    AttendanceLimit = table.Column<int>(type: "integer", nullable: false),
                    AttendanceSignup = table.Column<bool>(type: "boolean", nullable: false),
                    Visibility = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attendants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    EventId = table.Column<int>(type: "integer", nullable: false),
                    EventId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendants_Events_EventId1",
                        column: x => x.EventId1,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sermons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SermonType = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    AudioLowUrl = table.Column<string>(type: "text", nullable: true),
                    AudioMedUrl = table.Column<string>(type: "text", nullable: true),
                    AudioHighUrl = table.Column<string>(type: "text", nullable: true),
                    VideoUrl = table.Column<string>(type: "text", nullable: true),
                    Visibility = table.Column<int>(type: "integer", nullable: false),
                    Views = table.Column<int>(type: "integer", nullable: false),
                    EventId = table.Column<int>(type: "integer", nullable: false),
                    EventId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sermons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sermons_Events_EventId1",
                        column: x => x.EventId1,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Streams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    LiveUrl = table.Column<string>(type: "text", nullable: true),
                    LiveMixlrUrl = table.Column<string>(type: "text", nullable: true),
                    Live = table.Column<bool>(type: "boolean", nullable: false),
                    Visibility = table.Column<int>(type: "integer", nullable: false),
                    Views = table.Column<int>(type: "integer", nullable: false),
                    EventId = table.Column<int>(type: "integer", nullable: false),
                    EventId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Streams_Events_EventId1",
                        column: x => x.EventId1,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    SecondLastName = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ContactNumber = table.Column<string>(type: "text", nullable: true),
                    MaritalStatus = table.Column<int>(type: "integer", nullable: false),
                    IsSpeaker = table.Column<bool>(type: "boolean", nullable: false),
                    StreetAddress = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Province = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<int>(type: "integer", nullable: false),
                    StreamId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_Streams_StreamId",
                        column: x => x.StreamId,
                        principalTable: "Streams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonSermon",
                columns: table => new
                {
                    SermonsId = table.Column<Guid>(type: "uuid", nullable: false),
                    SpeakersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonSermon", x => new { x.SermonsId, x.SpeakersId });
                    table.ForeignKey(
                        name: "FK_PersonSermon_People_SpeakersId",
                        column: x => x.SpeakersId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonSermon_Sermons_SermonsId",
                        column: x => x.SermonsId,
                        principalTable: "Sermons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendants_EventId1",
                table: "Attendants",
                column: "EventId1");

            migrationBuilder.CreateIndex(
                name: "IX_People_StreamId",
                table: "People",
                column: "StreamId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonSermon_SpeakersId",
                table: "PersonSermon",
                column: "SpeakersId");

            migrationBuilder.CreateIndex(
                name: "IX_Sermons_EventId1",
                table: "Sermons",
                column: "EventId1");

            migrationBuilder.CreateIndex(
                name: "IX_Streams_EventId1",
                table: "Streams",
                column: "EventId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendants");

            migrationBuilder.DropTable(
                name: "Churches");

            migrationBuilder.DropTable(
                name: "PersonSermon");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Sermons");

            migrationBuilder.DropTable(
                name: "Streams");

            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
