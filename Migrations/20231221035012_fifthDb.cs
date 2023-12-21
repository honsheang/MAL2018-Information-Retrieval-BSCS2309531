using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrailApp.Migrations
{
    /// <inheritdoc />
    public partial class fifthDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievement",
                schema: "CW2",
                columns: table => new
                {
                    achievementID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    achievementTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    achievedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievement", x => x.achievementID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievement",
                schema: "CW2");
        }
    }
}
