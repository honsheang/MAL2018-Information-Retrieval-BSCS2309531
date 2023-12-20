using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrailApp.Migrations
{
    /// <inheritdoc />
    public partial class secondDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profile",
                schema: "CW2",
                columns: table => new
                {
                    profileID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    profileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    creationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.profileID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profile",
                schema: "CW2");
        }
    }
}
