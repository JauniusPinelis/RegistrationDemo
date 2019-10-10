using Microsoft.EntityFrameworkCore.Migrations;

namespace Registration.Infrastructure.Migrations
{
    public partial class bugfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblMeta_RegistrationValue_tblMeta_Dropdown_DropdownId",
                table: "tblMeta_RegistrationValue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblMeta_RegistrationValue",
                table: "tblMeta_RegistrationValue");

            migrationBuilder.RenameTable(
                name: "tblMeta_RegistrationValue",
                newName: "tblMeta_DropdownValue");

            migrationBuilder.RenameIndex(
                name: "IX_tblMeta_RegistrationValue_DropdownId",
                table: "tblMeta_DropdownValue",
                newName: "IX_tblMeta_DropdownValue_DropdownId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblMeta_DropdownValue",
                table: "tblMeta_DropdownValue",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblMeta_DropdownValue_tblMeta_Dropdown_DropdownId",
                table: "tblMeta_DropdownValue",
                column: "DropdownId",
                principalTable: "tblMeta_Dropdown",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblMeta_DropdownValue_tblMeta_Dropdown_DropdownId",
                table: "tblMeta_DropdownValue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblMeta_DropdownValue",
                table: "tblMeta_DropdownValue");

            migrationBuilder.RenameTable(
                name: "tblMeta_DropdownValue",
                newName: "tblMeta_RegistrationValue");

            migrationBuilder.RenameIndex(
                name: "IX_tblMeta_DropdownValue_DropdownId",
                table: "tblMeta_RegistrationValue",
                newName: "IX_tblMeta_RegistrationValue_DropdownId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblMeta_RegistrationValue",
                table: "tblMeta_RegistrationValue",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblMeta_RegistrationValue_tblMeta_Dropdown_DropdownId",
                table: "tblMeta_RegistrationValue",
                column: "DropdownId",
                principalTable: "tblMeta_Dropdown",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
