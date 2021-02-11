using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManager.Data.Migrations
{
    public partial class update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketTypeEnum",
                table: "Ticket");

            migrationBuilder.AddColumn<int>(
                name: "WOTicketType",
                table: "Ticket",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WOTicketType",
                table: "Ticket");

            migrationBuilder.AddColumn<int>(
                name: "TicketTypeEnum",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
