using Microsoft.EntityFrameworkCore.Migrations;

namespace BasketballTracking.Migrations
{
    public partial class AddedImageURLProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Conferences",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Conferences",
                keyColumn: "ConferenceId",
                keyValue: 1,
                column: "ImageURL",
                value: "https://vignette.wikia.nocookie.net/prosportsteams/images/f/ff/Eastern_Conference_%28NBA%29.gif/revision/latest?cb=20120914185141");

            migrationBuilder.UpdateData(
                table: "Conferences",
                keyColumn: "ConferenceId",
                keyValue: 2,
                column: "ImageURL",
                value: "https://vignette.wikia.nocookie.net/prosportsteams/images/1/10/Western_Conference_%28NBA%29.gif/revision/latest?cb=20120914191716");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "ImageURL",
                value: "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/2544.png");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "ImageURL",
                value: "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201939.png");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "ImageURL",
                value: "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202689.png");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 4,
                columns: new[] { "ImageURL", "Name" },
                values: new object[] { "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203507.png", "Giannis Antetokounmpo" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "ImageURL",
                value: "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201567.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "ImageURL",
                value: "https://stats.nba.com/media/img/teams/logos/CLE_logo.svg");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "ImageURL",
                value: "https://stats.nba.com/media/img/teams/logos/MIL_logo.svg");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "ImageURL",
                value: "https://stats.nba.com/media/img/teams/logos/BOS_logo.svg");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 4,
                column: "ImageURL",
                value: "https://stats.nba.com/media/img/teams/logos/LAL_logo.svg");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "ImageURL",
                value: "https://stats.nba.com/media/img/teams/logos/GSW_logo.svg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Conferences");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "Name",
                value: "Thanasis Antetokounmpo");
        }
    }
}
