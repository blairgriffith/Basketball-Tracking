﻿// <auto-generated />
using BasketballTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BasketballTracking.Migrations
{
    [DbContext(typeof(SiteContext))]
    partial class SiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BasketballTracking.Models.Conference", b =>
                {
                    b.Property<int>("ConferenceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ConferenceId");

                    b.ToTable("Conferences");

                    b.HasData(
                        new { ConferenceId = 1, Name = "Eastern Conference" },
                        new { ConferenceId = 2, Name = "Western Conference" }
                    );
                });

            modelBuilder.Entity("BasketballTracking.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("TeamId");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new { PlayerId = 1, Name = "LeBron James", TeamId = 4 },
                        new { PlayerId = 2, Name = "Stephen Curry", TeamId = 5 },
                        new { PlayerId = 3, Name = "Kemba Walker", TeamId = 3 },
                        new { PlayerId = 4, Name = "Thanasis Antetokounmpo", TeamId = 2 },
                        new { PlayerId = 5, Name = "Kevin Love", TeamId = 1 }
                    );
                });

            modelBuilder.Entity("BasketballTracking.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConferenceId");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.HasKey("TeamId");

                    b.HasIndex("ConferenceId");

                    b.ToTable("Teams");

                    b.HasData(
                        new { TeamId = 1, ConferenceId = 1, Location = "Cleveland", Name = "Cavaliers" },
                        new { TeamId = 2, ConferenceId = 1, Location = "Milwaukee", Name = "Bucks" },
                        new { TeamId = 3, ConferenceId = 1, Location = "Boston", Name = "Celtics" },
                        new { TeamId = 4, ConferenceId = 2, Location = "Los Angeles", Name = "Lakers" },
                        new { TeamId = 5, ConferenceId = 2, Location = "San Francisco", Name = "Warriors" }
                    );
                });

            modelBuilder.Entity("BasketballTracking.Models.Player", b =>
                {
                    b.HasOne("BasketballTracking.Models.Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BasketballTracking.Models.Team", b =>
                {
                    b.HasOne("BasketballTracking.Models.Conference")
                        .WithMany("Teams")
                        .HasForeignKey("ConferenceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}