using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrailApp.Migrations
{
    /// <inheritdoc />
    public partial class initialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                schema: "CW2",
                columns: table => new
                {
                    userID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    archivedAccess = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    height = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userID);
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users",
                schema: "CW2");
        }
    }
}
