using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Registration.Infrastructure.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblData_Registration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsWorkNeeded = table.Column<bool>(nullable: false),
                    WorkAppliedBy = table.Column<int>(nullable: false),
                    IsBusinessClient = table.Column<bool>(nullable: false),
                    CalculationType = table.Column<int>(nullable: false),
                    IsImportantClient = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblData_Registration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblMeta_Question",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMeta_Question", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblMeta_Dropdown",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    QuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMeta_Dropdown", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblMeta_Dropdown_tblMeta_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "tblMeta_Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblMeta_RegistrationValue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    DropdownId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMeta_RegistrationValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblMeta_RegistrationValue_tblMeta_Dropdown_DropdownId",
                        column: x => x.DropdownId,
                        principalTable: "tblMeta_Dropdown",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tblMeta_Question",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Reikia atlikti rangos darbus", null },
                    { 2, "Rangos darbos atliks", null },
                    { 3, "Verslo klientas", null },
                    { 4, "Skaiciavimo budas", null },
                    { 5, "Skaiciavimo budas", null }
                });

            migrationBuilder.InsertData(
                table: "tblMeta_Dropdown",
                columns: new[] { "Id", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Reikia atlikti rangos darbus", 1 },
                    { 2, "Rangos darbos atliks", 2 },
                    { 3, "Verslo klientas", 3 },
                    { 4, "Skaiciavimo budas", 4 },
                    { 5, "Svarbus Klientas", 5 }
                });

            migrationBuilder.InsertData(
                table: "tblMeta_RegistrationValue",
                columns: new[] { "Id", "DropdownId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Taip" },
                    { 2, 1, "Ne" },
                    { 3, 2, "Metinis Rangovas" },
                    { 4, 2, "Kiti" },
                    { 5, 3, "Taip" },
                    { 6, 3, "Ne" },
                    { 7, 4, "Automatinis" },
                    { 8, 4, "Paprastas" },
                    { 9, 5, "Taip" },
                    { 10, 5, "Ne" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblMeta_Dropdown_QuestionId",
                table: "tblMeta_Dropdown",
                column: "QuestionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblMeta_RegistrationValue_DropdownId",
                table: "tblMeta_RegistrationValue",
                column: "DropdownId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblData_Registration");

            migrationBuilder.DropTable(
                name: "tblMeta_RegistrationValue");

            migrationBuilder.DropTable(
                name: "tblMeta_Dropdown");

            migrationBuilder.DropTable(
                name: "tblMeta_Question");
        }
    }
}
