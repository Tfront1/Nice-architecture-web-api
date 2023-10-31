using DataAccess.Models.Configurations;
using DataAccess.Models.Intermediate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.ClientSpace;
using DataAccess.Models.HotelSpace;
using DataAccess.Models.SkiPassSpace;
using DataAccess.Models.SlopeSpace;

namespace DataAccess.Context
{
    public class SkiResContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientProfile> ClientProfiles { get; set; }
        public DbSet<ClientPromotion> ClientPromotions { get; set; }
        public DbSet<ClientRoomReservation> ClientRoomReservations { get; set; }
        public DbSet<ClientSkiPass> ClientSkiPasses { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Lift> Lift { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<SkiPass> SkiPass { get; set; }
        public DbSet<Slope> Slope { get; set; }
        public SkiResContext(DbContextOptions<SkiResContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=lab3CodeFirst;Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString)
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging()
                .LogTo(Console.WriteLine,
                new[] { DbLoggerCategory.Database.Command.Name },
                LogLevel.Information);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new HotelConfiguration());
            modelBuilder.ApplyConfiguration(new LiftConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new SkiPassConfiguration());
            modelBuilder.ApplyConfiguration(new SlopeConfiguration());
        }
    }
}
