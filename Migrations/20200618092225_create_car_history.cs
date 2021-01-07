using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarBooking.Migrations
{
    public partial class create_car_history : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarHistories",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarHistories", x => new { x.CarId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_CarHistories_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarHistories_Employees_CarId",
                        column: x => x.CarId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarHistories");
        }
    }
}
