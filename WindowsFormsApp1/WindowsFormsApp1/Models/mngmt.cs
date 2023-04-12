using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Entity;

namespace TrenIstasyonuProjesi.Models
{
    public class TrainStationDbContext : DbContext
    {
        public TrainStationDbContext(DbContextOptions<TrainStationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TrainStation> TrainStations { get; set; }
        public DbSet<TrainSchedule> TrainSchedules { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class TrainStation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
    }
    public class TrainSchedule
    {
        public int Id { get; set; }
        public int DepartureStationId { get; set; }
        public int ArrivalStationId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        public TrainStation DepartureStation { get; set; }
        public TrainStation ArrivalStation { get; set; }
    }


}
