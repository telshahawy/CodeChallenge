using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeChallenge.Server.Migrations
{
    public partial class AddTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ShiftType",
                table: "ShiftType");

            migrationBuilder.RenameTable(
                name: "ShiftType",
                newName: "ShiftTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShiftTypes",
                table: "ShiftTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shifts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shifts_ShiftTypes_ShiftTypeId",
                        column: x => x.ShiftTypeId,
                        principalTable: "ShiftTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_EmployeeId",
                table: "Shifts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_ShiftTypeId",
                table: "Shifts",
                column: "ShiftTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShiftTypes",
                table: "ShiftTypes");

            migrationBuilder.RenameTable(
                name: "ShiftTypes",
                newName: "ShiftType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShiftType",
                table: "ShiftType",
                column: "Id");
        }
    }
}
