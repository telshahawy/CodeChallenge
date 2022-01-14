using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeChallenge.Server.Migrations
{
    public partial class AddShifts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ShiftType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    BreakPerHourInMin = table.Column<int>(type: "int", nullable: false),
                    BreakPerFourHoursInMin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftType", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ShiftType",
                columns: new[] { "Id", "BreakPerFourHoursInMin", "BreakPerHourInMin", "EndTime", "Name", "StartTime" },
                values: new object[] { 1, 20, 10, new TimeSpan(0, 16, 0, 0, 0), "Morning Shift", new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "ShiftType",
                columns: new[] { "Id", "BreakPerFourHoursInMin", "BreakPerHourInMin", "EndTime", "Name", "StartTime" },
                values: new object[] { 2, 20, 10, new TimeSpan(0, 8, 0, 0, 0), "Night Shift", new TimeSpan(0, 16, 0, 0, 0) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShiftType");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Employees");
        }
    }
}
