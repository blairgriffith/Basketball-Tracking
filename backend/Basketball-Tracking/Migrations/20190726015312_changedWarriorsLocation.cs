using Microsoft.EntityFrameworkCore.Migrations;

namespace BasketballTracking.Migrations
{
    public partial class changedWarriorsLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "Location",
                value: "Golden State");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "Location",
                value: "San Francisco");
        }
    }
}
