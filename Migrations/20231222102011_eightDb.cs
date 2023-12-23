using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrailApp.Migrations
{
    /// <inheritdoc />
    public partial class eightDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "trailID",
                schema: "CW2",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "userID",
                schema: "CW2",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "profileID",
                schema: "CW2",
                table: "Activity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "trailID",
                schema: "CW2",
                table: "Activity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "profileID",
                schema: "CW2",
                table: "Achievement",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "trailID",
                schema: "CW2",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "userID",
                schema: "CW2",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "profileID",
                schema: "CW2",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "trailID",
                schema: "CW2",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "profileID",
                schema: "CW2",
                table: "Achievement");
        }
    }
}
