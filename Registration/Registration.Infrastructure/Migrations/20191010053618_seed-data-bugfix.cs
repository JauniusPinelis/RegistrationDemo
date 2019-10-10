using Microsoft.EntityFrameworkCore.Migrations;

namespace Registration.Infrastructure.Migrations
{
    public partial class seeddatabugfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblMeta_Question",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Svarbus Klientas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblMeta_Question",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Skaiciavimo budas");
        }
    }
}
