using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalTest.DataAccess.Migrations
{
    public partial class Creatingdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressLine1 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    City = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CountryIsoCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Locale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    State = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressLine1);
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

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Organizations_Addresses_AddressLine1",
                        column: x => x.AddressLine1,
                        principalTable: "Addresses",
                        principalColumn: "AddressLine1",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    FirtName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Email);
                    table.ForeignKey(
                        name: "FK_Persons_Addresses_AddressLine1",
                        column: x => x.AddressLine1,
                        principalTable: "Addresses",
                        principalColumn: "AddressLine1",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_getRegistrationResponses_OrganizationName",
                table: "getRegistrationResponses",
                column: "OrganizationName");

            migrationBuilder.CreateIndex(
                name: "IX_getRegistrationResponses_PersonEmail",
                table: "getRegistrationResponses",
                column: "PersonEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_AddressLine1",
                table: "Organizations",
                column: "AddressLine1");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AddressLine1",
                table: "Persons",
                column: "AddressLine1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "getRegistrationResponses");

            migrationBuilder.DropTable(
                name: "registrationResponses");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
