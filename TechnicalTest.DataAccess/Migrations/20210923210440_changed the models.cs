using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalTest.DataAccess.Migrations
{
    public partial class changedthemodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "getRegistrationResponses");

            migrationBuilder.DropTable(
                name: "registrationResponses");

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Locale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationName = table.Column<string>(type: "nvarchar(120)", nullable: true),
                    PersonEmail = table.Column<string>(type: "nvarchar(254)", nullable: true),
                    RegistrationDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registrations_Organizations_OrganizationName",
                        column: x => x.OrganizationName,
                        principalTable: "Organizations",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registrations_Persons_PersonEmail",
                        column: x => x.PersonEmail,
                        principalTable: "Persons",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_OrganizationName",
                table: "Registrations",
                column: "OrganizationName");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_PersonEmail",
                table: "Registrations",
                column: "PersonEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.CreateTable(
                name: "getRegistrationResponses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Locale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationName = table.Column<string>(type: "nvarchar(120)", nullable: true),
                    PersonEmail = table.Column<string>(type: "nvarchar(254)", nullable: true),
                    RegistrationDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_getRegistrationResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_getRegistrationResponses_Organizations_OrganizationName",
                        column: x => x.OrganizationName,
                        principalTable: "Organizations",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_getRegistrationResponses_Persons_PersonEmail",
                        column: x => x.PersonEmail,
                        principalTable: "Persons",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "registrationResponses",
                columns: table => new
                {
                    RegistrationId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registrationResponses", x => x.RegistrationId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_getRegistrationResponses_OrganizationName",
                table: "getRegistrationResponses",
                column: "OrganizationName");

            migrationBuilder.CreateIndex(
                name: "IX_getRegistrationResponses_PersonEmail",
                table: "getRegistrationResponses",
                column: "PersonEmail");
        }
    }
}
