using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrailApp.Migrations
{
    /// <inheritdoc />
    public partial class sixDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AchievementComment",
                schema: "CW2",
                columns: table => new
                {
                    achievementCommentID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    timestamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    achievementID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    profileID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AchievementComment", x => x.achievementCommentID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AchievementComment",
                schema: "CW2");
        }
    }
}
