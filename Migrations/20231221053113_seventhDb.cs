using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrailApp.Migrations
{
    /// <inheritdoc />
    public partial class seventhDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmergencyContact",
                schema: "CW2",
                columns: table => new
                {
                    eContactID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    eContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    relationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContact", x => x.eContactID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmergencyContact",
                schema: "CW2");
        }
    }
}
