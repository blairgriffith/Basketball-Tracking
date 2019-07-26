using BasketballTracking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BasketballTracking
{
    public class SiteContext : DbContext
    {
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BasketballTrackingSite;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conference>().HasData(
                new Conference
                {
                    ConferenceId = 1,
                    Name = "Eastern Conference",
                    ImageURL = "https://vignette.wikia.nocookie.net/prosportsteams/images/f/ff/Eastern_Conference_%28NBA%29.gif/revision/latest?cb=20120914185141"
                },
                new Conference
                {
                    ConferenceId = 2,
                    Name = "Western Conference",
                    ImageURL = "https://vignette.wikia.nocookie.net/prosportsteams/images/1/10/Western_Conference_%28NBA%29.gif/revision/latest?cb=20120914191716"
                }
                );


            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    TeamId = 1,
                    Name = "Cavaliers",
                    Location = "Cleveland",
                    ImageURL = "https://stats.nba.com/media/img/teams/logos/CLE_logo.svg",

                    ConferenceId = 1

                    
                },
                new Team
                {
                    TeamId = 2,
                    Name = "Bucks",
                    Location = "Milwaukee",
                    ImageURL = "https://stats.nba.com/media/img/teams/logos/MIL_logo.svg",

                    ConferenceId = 1
                },
                new Team
                {
                    TeamId = 3,
                    Name = "Celtics",
                    Location = "Boston",
                    ImageURL = "https://stats.nba.com/media/img/teams/logos/BOS_logo.svg",

                    ConferenceId = 1
                },
                new Team
                {
                    TeamId = 4,
                    Name = "Lakers",
                    Location = "Los Angeles",
                    ImageURL = "https://stats.nba.com/media/img/teams/logos/LAL_logo.svg",

                    ConferenceId = 2
                },
                new Team
                {
                    TeamId = 5,
                    Name = "Warriors",
                    Location = "Golden State",
                    ImageURL = "https://stats.nba.com/media/img/teams/logos/GSW_logo.svg",

                    ConferenceId = 2
                },
                new Team
                {
                    TeamId = 6,
                    Name = "Trail Blazers",
                    Location = "Portland",
                    ImageURL = "https://stats.nba.com/media/img/teams/logos/POR_logo.svg",

                    ConferenceId = 2
                },
                new Team
                {
                    TeamId = 7,
                    Name = "Raptors",
                    Location = "Toronto",
                    ImageURL = "https://stats.nba.com/media/img/teams/logos/TOR_logo.svg",

                    ConferenceId = 1
                },
                new Team
                {
                    TeamId = 8,
                    Name = "Clippers",
                    Location = "Los Angeles",
                    ImageURL = "https://stats.nba.com/media/img/teams/logos/LAC_logo.svg",

                    ConferenceId = 2
                }
                );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    PlayerId = 1,
                    Name = "LeBron James",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/2544.png",

                    TeamId = 4
                },
                new Player
                {
                    PlayerId = 2,
                    Name = "Stephen Curry",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201939.png",

                    TeamId = 5
                },
                new Player
                {
                    PlayerId = 3,
                    Name = "Kemba Walker",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202689.png",

                    TeamId = 3
                },
                new Player
                {
                    PlayerId = 4,
                    Name = "Giannis Antetokounmpo",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203507.png",

                    TeamId = 2
                },
                new Player
                {
                    PlayerId = 5,
                    Name = "Kevin Love",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201567.png",

                    TeamId = 1
                },
                new Player
                {
                    PlayerId = 6,
                    Name = "Kyle Kuzma",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628398.png",

                    TeamId = 4
                },
                new Player
                {
                    PlayerId = 7,
                    Name = "DeMarcus Cousins",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202326.png",

                    TeamId = 4
                },
                new Player
                {
                    PlayerId = 8,
                    Name = "Anthony Davis",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203076.png",

                    TeamId = 4
                },
                new Player
                {
                    PlayerId = 9,
                    Name = "Khris Middleton",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203114.png",

                    TeamId = 2
                },
                new Player
                {
                    PlayerId = 10,
                    Name = "Eric Bledsoe",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202339.png",

                    TeamId = 2
                },
                new Player
                {
                    PlayerId = 11,
                    Name = "Brook Lopez",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201572.png",

                    TeamId = 2
                },
                new Player
                {
                    PlayerId = 12,
                    Name = "Jayson Tatum",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628369.png",

                    TeamId = 3
                },
                new Player
                {
                    PlayerId = 13,
                    Name = "Jaylen Brown",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627759.png",

                    TeamId = 3
                },
                new Player
                {
                    PlayerId = 14,
                    Name = "Marcus Smart",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203935.png",

                    TeamId = 3
                },
                new Player
                {
                    PlayerId = 15,
                    Name = "Darius Garland",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629636.png",

                    TeamId = 1
                },
                new Player
                {
                    PlayerId = 16,
                    Name = "Collin Sexton",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629012.png",

                    TeamId = 1
                },
                new Player
                {
                    PlayerId = 17,
                    Name = "Larry Nance Jr.",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626204.png",

                    TeamId = 1
                },
                new Player
                {
                    PlayerId = 18,
                    Name = "D'Angelo Russel",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626156.png",

                    TeamId = 5
                },
                new Player
                {
                    PlayerId = 19,
                    Name = "Klay Thompson",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202691.png",

                    TeamId = 5
                },
                new Player
                {
                    PlayerId = 20,
                    Name = "Draymond Green",
                    ImageURL = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203110.png",

                    TeamId = 5
                },
                new Player
                {
                    PlayerId = 21,
                    Name = "",
                    ImageURL = "",

                    TeamId = 6
                },
                new Player
                {
                    PlayerId = 22,
                    Name = "",
                    ImageURL = "",

                    TeamId = 6
                },
                new Player
                {
                    PlayerId = 23,
                    Name = "",
                    ImageURL = "",

                    TeamId = 6
                },
                new Player
                {
                    PlayerId = ,
                    Name = "",
                    ImageURL = "",

                    TeamId =
                },
                new Player
                {
                    PlayerId = ,
                    Name = "",
                    ImageURL = "",

                    TeamId =
                },
                new Player
                {
                    PlayerId = ,
                    Name = "",
                    ImageURL = "",

                    TeamId =
                },
                new Player
                {
                    PlayerId = ,
                    Name = "",
                    ImageURL = "",

                    TeamId =
                },
                new Player
                {
                    PlayerId = ,
                    Name = "",
                    ImageURL = "",

                    TeamId =
                },
                new Player
                {
                    PlayerId = ,
                    Name = "",
                    ImageURL = "",

                    TeamId =
                },


                );
        }
    }
}