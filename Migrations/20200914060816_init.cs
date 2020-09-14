using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnbarUchotu.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Rayon = table.Column<string>(nullable: true),
                    SonSatis = table.Column<DateTime>(nullable: false),
                    Elaqe = table.Column<string>(nullable: true),
                    Borc = table.Column<int>(nullable: false),
                    SatisSayi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MalAdi = table.Column<string>(nullable: true),
                    Qablasma = table.Column<string>(nullable: true),
                    AnbardakiMiqdar = table.Column<int>(nullable: false),
                    AlisQiymeti = table.Column<int>(nullable: false),
                    SatisQiymeti = table.Column<int>(nullable: false),
                    Istehsal = table.Column<DateTime>(nullable: false),
                    SonIstifade = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Satislar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MusteriId = table.Column<int>(nullable: false),
                    CemiQiymet = table.Column<int>(nullable: false),
                    SatisTarixi = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satislar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Satislar_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GelenMallar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MalId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    GelenSay = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GelenMallar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GelenMallar_Products_MalId",
                        column: x => x.MalId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SatilmisMallar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MalId = table.Column<int>(nullable: false),
                    MalAdi = table.Column<string>(nullable: true),
                    SatisId = table.Column<int>(nullable: false),
                    SatilanMiqdar = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatilmisMallar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SatilmisMallar_Products_MalId",
                        column: x => x.MalId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SatilmisMallar_Satislar_SatisId",
                        column: x => x.SatisId,
                        principalTable: "Satislar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GelenMallar_MalId",
                table: "GelenMallar",
                column: "MalId");

            migrationBuilder.CreateIndex(
                name: "IX_SatilmisMallar_MalId",
                table: "SatilmisMallar",
                column: "MalId");

            migrationBuilder.CreateIndex(
                name: "IX_SatilmisMallar_SatisId",
                table: "SatilmisMallar",
                column: "SatisId");

            migrationBuilder.CreateIndex(
                name: "IX_Satislar_MusteriId",
                table: "Satislar",
                column: "MusteriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GelenMallar");

            migrationBuilder.DropTable(
                name: "SatilmisMallar");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Satislar");

            migrationBuilder.DropTable(
                name: "Musteriler");
        }
    }
}
