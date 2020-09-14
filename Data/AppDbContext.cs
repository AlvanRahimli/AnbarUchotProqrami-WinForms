using AnbarUchotu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnbarUchotu.Data
{
    class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Anbar.db");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }

        public DbSet<Mal> Products { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<SatilmisMal> SatilmisMallar { get; set; }
        public DbSet<GelenMal> GelenMallar { get; set; }
    }
}
