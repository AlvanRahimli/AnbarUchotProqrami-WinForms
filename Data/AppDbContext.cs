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
            builder.Entity<Mal>().HasData(
                new Mal()
                {
                    Id = 1,
                    MalAdi = "test mal",
                    AlisQiymeti = 150,
                    SatisQiymeti = 160,
                    AnbardakiMiqdar = 2,
                    Istehsal = DateTime.Now,
                    SonIstifade = DateTime.Now.AddMonths(6),
                    Qablasma = "100 ml"
                },
                new Mal()
                {
                    Id = 2,
                    MalAdi = "test mal 2",
                    AlisQiymeti = 120,
                    SatisQiymeti = 140,
                    AnbardakiMiqdar = 4,
                    Istehsal = DateTime.Now,
                    SonIstifade = DateTime.Now.AddMonths(6),
                    Qablasma = "50 ml"
                });

            builder.Entity<Musteri>().HasData(
                new Musteri()
                {
                    Id = 1,
                    Name = "test musteri 1",
                    SatisSayi = 15,
                    Borc = 75,
                    Elaqe = "+994772204323",
                    Rayon = "Balakən"
                },
                new Musteri()
                {
                    Id = 2,
                    Name = "test musteri 2",
                    SatisSayi = 1,
                    Borc = 56,
                    Elaqe = "basqa nomre",
                    Rayon = "Qazax"
                });
        }

        public DbSet<Mal> Products { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<SatilmisMal> SatilmisMallar { get; set; }
    }
}
