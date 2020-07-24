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
                    BirEdedinQiymeti = 150,
                    Miqdar = 2,
                    Istehsal = DateTime.Now,
                    SonIstifade = DateTime.Now.AddMonths(6),
                    Qablasma = "100 ml",
                    YekunQiymet = 300
                },
                new Mal()
                {
                    Id = 2,
                    MalAdi = "test mal 2",
                    BirEdedinQiymeti = 12,
                    Miqdar = 4,
                    Istehsal = DateTime.Now,
                    SonIstifade = DateTime.Now.AddMonths(6),
                    Qablasma = "50 ml",
                    YekunQiymet = 48
                });
        }

        public DbSet<Mal> Products { get; set; }
    }
}
