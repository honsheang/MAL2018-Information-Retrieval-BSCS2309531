using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrailApp.Migrations
{
    /// <inheritdoc />
    public partial class forthDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity",
                schema: "CW2",
                columns: table => new
                {
                    activityID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    activityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    units = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activityTimePreference = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.activityID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activity",
                schema: "CW2");
        }
    }
}
