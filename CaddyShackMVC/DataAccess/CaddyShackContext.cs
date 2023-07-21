using CaddyShackMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CaddyShackMVC.DataAccess
{
    public class CaddyShackContext : DbContext
    {
        public DbSet<GolfBag> GolfBags { get; set; }
        public DbSet<Club> Clubs { get; set; }

        public CaddyShackContext(DbContextOptions<CaddyShackContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GolfBag>().HasData(
                new GolfBag { Id = 1, Capacity = 18, Player = "Sung-jae Im" },
                new GolfBag { Id = 2, Capacity = 14, Player = "Lydia Ko" }
            );

            modelBuilder.Entity<Club>().HasData(
                new Club { Id = 1, Name = "Driver", GolfBagId = 1 },
                new Club { Id = 2, Name = "Putter", GolfBagId = 1 },
                new Club { Id = 3, Name = "5 Iron", GolfBagId = 1 },
                new Club { Id = 4, Name = "Driver", GolfBagId = 2 },
                new Club { Id = 5, Name = "Putter", GolfBagId = 2 },
                new Club { Id = 6, Name = "9 Iron", GolfBagId = 2 }
            );
        }
    }
}
