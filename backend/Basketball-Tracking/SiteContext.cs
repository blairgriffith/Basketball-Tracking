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
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=DripCoffeeAlbumCollection;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);
                          //.UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}