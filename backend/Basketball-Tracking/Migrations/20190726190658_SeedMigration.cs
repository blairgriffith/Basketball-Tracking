using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BasketballTracking.Migrations
{
    public partial class SeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conferences",
                columns: table => new
                {
                    ConferenceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conferences", x => x.ConferenceId);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    ConferenceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Teams_Conferences_ConferenceId",
                        column: x => x.ConferenceId,
                        principalTable: "Conferences",
                        principalColumn: "ConferenceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Conferences",
                columns: new[] { "ConferenceId", "ImageURL", "Name" },
                values: new object[] { 1, "https://vignette.wikia.nocookie.net/prosportsteams/images/f/ff/Eastern_Conference_%28NBA%29.gif/revision/latest?cb=20120914185141", "Eastern Conference" });

            migrationBuilder.InsertData(
                table: "Conferences",
                columns: new[] { "ConferenceId", "ImageURL", "Name" },
                values: new object[] { 2, "https://vignette.wikia.nocookie.net/prosportsteams/images/1/10/Western_Conference_%28NBA%29.gif/revision/latest?cb=20120914191716", "Western Conference" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "ConferenceId", "ImageURL", "Location", "Name" },
                values: new object[,]
                {
                    { 1, 1, "https://stats.nba.com/media/img/teams/logos/CLE_logo.svg", "Cleveland", "Cavaliers" },
                    { 2, 1, "https://stats.nba.com/media/img/teams/logos/MIL_logo.svg", "Milwaukee", "Bucks" },
                    { 3, 1, "https://stats.nba.com/media/img/teams/logos/BOS_logo.svg", "Boston", "Celtics" },
                    { 7, 1, "https://stats.nba.com/media/img/teams/logos/TOR_logo.svg", "Toronto", "Raptors" },
                    { 4, 2, "https://stats.nba.com/media/img/teams/logos/LAL_logo.svg", "Los Angeles", "Lakers" },
                    { 5, 2, "https://stats.nba.com/media/img/teams/logos/GSW_logo.svg", "Golden State", "Warriors" },
                    { 6, 2, "https://stats.nba.com/media/img/teams/logos/POR_logo.svg", "Portland", "Trail Blazers" },
                    { 8, 2, "https://stats.nba.com/media/img/teams/logos/LAC_logo.svg", "Los Angeles", "Clippers" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "ImageURL", "Name", "TeamId" },
                values: new object[,]
                {
                    { 5, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201567.png", "Kevin Love", 1 },
                    { 30, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202695.png", "Kawhi Leonard", 8 },
                    { 29, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202331.png", "Paul George", 8 },
                    { 24, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203468.png", "CJ McCollom", 6 },
                    { 23, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203994.png", "Jusuf Nurkic", 6 },
                    { 22, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203918.png", "Rodney Hood", 6 },
                    { 21, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203081.png", "Damien Lillard", 6 },
                    { 20, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203110.png", "Draymond Green", 5 },
                    { 19, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202691.png", "Klay Thompson", 5 },
                    { 18, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626156.png", "D'Angelo Russel", 5 },
                    { 2, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201939.png", "Stephen Curry", 5 },
                    { 8, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203076.png", "Anthony Davis", 4 },
                    { 7, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202326.png", "DeMarcus Cousins", 4 },
                    { 6, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628398.png", "Kyle Kuzma", 4 },
                    { 1, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/2544.png", "LeBron James", 4 },
                    { 28, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627832.png", "Fred VanVleet", 7 },
                    { 27, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201188.png", "Marc Gasol", 7 },
                    { 26, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201586.png", "Serge Ibaka", 7 },
                    { 25, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/200768.png", "Kyle Lowry", 7 },
                    { 14, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203935.png", "Marcus Smart", 3 },
                    { 13, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627759.png", "Jaylen Brown", 3 },
                    { 12, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628369.png", "Jayson Tatum", 3 },
                    { 3, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202689.png", "Kemba Walker", 3 },
                    { 11, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201572.png", "Brook Lopez", 2 },
                    { 10, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202339.png", "Eric Bledsoe", 2 },
                    { 9, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203114.png", "Khris Middleton", 2 },
                    { 4, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203507.png", "Giannis Antetokounmpo", 2 },
                    { 17, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626204.png", "Larry Nance Jr.", 1 },
                    { 16, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629012.png", "Collin Sexton", 1 },
                    { 15, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629636.png", "Darius Garland", 1 },
                    { 31, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/101150.png", "Lou Williams", 8 },
                    { 32, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201976.png", "Patrick Beverly", 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ConferenceId",
                table: "Teams",
                column: "ConferenceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Conferences");
        }
    }
}
