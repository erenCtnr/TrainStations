using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using TrenIstasyonuProjesi.Models;

namespace TrenIstasyonuProjesi.Data
{
    public class TrenIstasyonuDbContext : DbContext
    {
        public TrenIstasyonuDbContext(DbContextOptions<TrenIstasyonuDbContext> options) : base(options)
        {

        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<TrenIstasyonu> TrenIstasyonlari { get; set; }
        public DbSet<TrenSeferi> TrenSeferleri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrenSeferi>()
                .HasOne(ts => ts.KalkisIstasyonu)
                .WithMany()
                .HasForeignKey(ts => ts.KalkisIstasyonuID);

            modelBuilder.Entity<TrenSeferi>()
                .HasOne(ts => ts.VarisIstasyonu)
                .WithMany()
                .HasForeignKey(ts => ts.VarisIstasyonuID);
        }
    }
}
