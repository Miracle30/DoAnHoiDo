using Microsoft.EntityFrameworkCore.Migrations;

namespace CarBooking.Migrations
{
    public partial class add_column_setnumberid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SeatNumberId",
                table: "Tickets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatNumberId",
                table: "Tickets");
        }
    }
}
