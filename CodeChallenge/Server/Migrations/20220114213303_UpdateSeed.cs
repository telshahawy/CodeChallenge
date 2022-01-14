using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeChallenge.Server.Migrations
{
    public partial class UpdateSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ShiftTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BreakPerFourHoursInMin", "BreakPerHourInMin" },
                values: new object[] { 30, 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ShiftTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BreakPerFourHoursInMin", "BreakPerHourInMin" },
                values: new object[] { 20, 10 });
        }
    }
}
