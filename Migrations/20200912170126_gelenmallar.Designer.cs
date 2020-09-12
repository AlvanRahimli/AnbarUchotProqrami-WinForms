﻿// <auto-generated />
using System;
using AnbarUchotu.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnbarUchotu.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200912170126_gelenmallar")]
    partial class gelenmallar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("AnbarUchotu.Models.GelenMal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("GelenSay")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MalId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MalId");

                    b.ToTable("GelenMallar");
                });

            modelBuilder.Entity("AnbarUchotu.Models.Mal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AlisQiymeti")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnbardakiMiqdar")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Istehsal")
                        .HasColumnType("TEXT");

                    b.Property<string>("MalAdi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Qablasma")
                        .HasColumnType("TEXT");

                    b.Property<int>("SatisQiymeti")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SonIstifade")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlisQiymeti = 150,
                            AnbardakiMiqdar = 2,
                            Istehsal = new DateTime(2020, 9, 12, 21, 1, 26, 166, DateTimeKind.Local).AddTicks(4346),
                            MalAdi = "test mal",
                            Qablasma = "100 ml",
                            SatisQiymeti = 160,
                            SonIstifade = new DateTime(2021, 3, 12, 21, 1, 26, 167, DateTimeKind.Local).AddTicks(2415)
                        },
                        new
                        {
                            Id = 2,
                            AlisQiymeti = 120,
                            AnbardakiMiqdar = 4,
                            Istehsal = new DateTime(2020, 9, 12, 21, 1, 26, 167, DateTimeKind.Local).AddTicks(3366),
                            MalAdi = "test mal 2",
                            Qablasma = "50 ml",
                            SatisQiymeti = 140,
                            SonIstifade = new DateTime(2021, 3, 12, 21, 1, 26, 167, DateTimeKind.Local).AddTicks(3379)
                        });
                });

            modelBuilder.Entity("AnbarUchotu.Models.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Borc")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Elaqe")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rayon")
                        .HasColumnType("TEXT");

                    b.Property<int>("SatisSayi")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SonSatis")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Musteriler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Borc = 75,
                            Elaqe = "+994772204323",
                            Name = "test musteri 1",
                            Rayon = "Balakən",
                            SatisSayi = 15,
                            SonSatis = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Borc = 56,
                            Elaqe = "basqa nomre",
                            Name = "test musteri 2",
                            Rayon = "Qazax",
                            SatisSayi = 1,
                            SonSatis = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AnbarUchotu.Models.SatilmisMal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MalAdi")
                        .HasColumnType("TEXT");

                    b.Property<int>("MalId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SatilanMiqdar")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SatisId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MalId");

                    b.HasIndex("SatisId");

                    b.ToTable("SatilmisMallar");
                });

            modelBuilder.Entity("AnbarUchotu.Models.Satis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CemiQiymet")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MusteriId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SatisTarixi")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MusteriId");

                    b.ToTable("Satislar");
                });

            modelBuilder.Entity("AnbarUchotu.Models.GelenMal", b =>
                {
                    b.HasOne("AnbarUchotu.Models.Mal", "Mal")
                        .WithMany("GelenMallar")
                        .HasForeignKey("MalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnbarUchotu.Models.SatilmisMal", b =>
                {
                    b.HasOne("AnbarUchotu.Models.Mal", "Mal")
                        .WithMany("SatilmisMallar")
                        .HasForeignKey("MalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnbarUchotu.Models.Satis", "Satis")
                        .WithMany("Mallar")
                        .HasForeignKey("SatisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnbarUchotu.Models.Satis", b =>
                {
                    b.HasOne("AnbarUchotu.Models.Musteri", "Musteri")
                        .WithMany("Satislar")
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}