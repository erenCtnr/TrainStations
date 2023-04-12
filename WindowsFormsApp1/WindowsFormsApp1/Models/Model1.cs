using Microsoft.EntityFrameworkCore;
using static System.Collections.Specialized.BitVector32;
using System.Data.Entity;
using WindowsFormsApp1.Models;

namespace TrenIstasyonuProjesi.Models
{
    public class TrainStationContext : DbContext
    {
        public TrainStationContext(DbContextOptions<TrainStationContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}
