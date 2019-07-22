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
                    Name = "Eastern Conference"
                },
                new Conference
                {
                    ConferenceId = 2,
                    Name = "Western Conference"
                }
                );


            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    TeamId = 1,
                    Name = "Cavaliers",
                    Location = "Cleveland",

                    ConferenceId = 1
                    
                },
                new Team
                {
                    TeamId = 2,
                    Name = "Bucks",
                    Location = "Milwaukee",

                    ConferenceId = 1
                },
                new Team
                {
                    TeamId = 3,
                    Name = "Celtics",
                    Location = "Boston",

                    ConferenceId = 1
                },
                new Team
                {
                    TeamId = 4,
                    Name = "Lakers",
                    Location = "Los Angeles",

                    ConferenceId = 2
                },
                new Team
                {
                    TeamId = 5,
                    Name = "Warriors",
                    Location = "San Francisco",

                    ConferenceId = 2
                }
                );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    PlayerId = 1,
                    Name = "LeBron James",

                    TeamId = 4
                },
                new Player
                {
                    PlayerId = 2,
                    Name = "Stephen Curry",

                    TeamId = 5
                },
                new Player
                {
                    PlayerId = 3,
                    Name = "Kemba Walker",

                    TeamId = 3
                },
                new Player
                {
                    PlayerId = 4,
                    Name = "Thanasis Antetokounmpo",

                    TeamId = 2
                },
                new Player
                {
                    PlayerId = 5,
                    Name = "Kevin Love",

                    TeamId = 1
                }

                );
        }
    }
}