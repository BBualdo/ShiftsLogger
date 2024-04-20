﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftsLoggerAPI.Migrations
{
  /// <inheritdoc />
  public partial class Initial : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Shifts",
          columns: table => new
          {
            ShiftId = table.Column<int>(type: "int", nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Shifts", x => x.ShiftId);
          });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Shifts");
    }
  }
}
