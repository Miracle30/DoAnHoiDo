using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CarBooking.Migrations
{
    public partial class create_car_history_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CarHistories",
                table: "CarHistories");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CarHistories",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarHistories",
                table: "CarHistories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CarHistories_CarId",
                table: "CarHistories",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CarHistories",
                table: "CarHistories");

            migrationBuilder.DropIndex(
                name: "IX_CarHistories_CarId",
                table: "CarHistories");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CarHistories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarHistories",
                table: "CarHistories",
                columns: new[] { "CarId", "EmployeeId" });
        }
    }
}
