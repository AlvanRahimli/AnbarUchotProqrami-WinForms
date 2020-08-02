using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnbarUchotu.Migrations
{
    public partial class Initial : Migration
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

            migrationBuilder.InsertData(
                table: "Musteriler",
                columns: new[] { "Id", "Borc", "Elaqe", "Name", "Rayon", "SatisSayi", "SonSatis" },
                values: new object[] { 1, 75, "+994772204323", "test musteri 1", "Balakən", 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Musteriler",
                columns: new[] { "Id", "Borc", "Elaqe", "Name", "Rayon", "SatisSayi", "SonSatis" },
                values: new object[] { 2, 56, "basqa nomre", "test musteri 2", "Qazax", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AlisQiymeti", "AnbardakiMiqdar", "Istehsal", "MalAdi", "Qablasma", "SatisQiymeti", "SonIstifade" },
                values: new object[] { 1, 150, 2, new DateTime(2020, 8, 2, 1, 47, 2, 363, DateTimeKind.Local).AddTicks(1155), "test mal", "100 ml", 160, new DateTime(2021, 2, 2, 1, 47, 2, 363, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AlisQiymeti", "AnbardakiMiqdar", "Istehsal", "MalAdi", "Qablasma", "SatisQiymeti", "SonIstifade" },
                values: new object[] { 2, 12, 4, new DateTime(2020, 8, 2, 1, 47, 2, 364, DateTimeKind.Local).AddTicks(494), "test mal 2", "50 ml", 160, new DateTime(2021, 2, 2, 1, 47, 2, 364, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.InsertData(
                table: "Satislar",
                columns: new[] { "Id", "CemiQiymet", "MusteriId", "SatisTarixi" },
                values: new object[] { 1, 155, 1, new DateTime(2020, 8, 2, 1, 47, 2, 365, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.InsertData(
                table: "SatilmisMallar",
                columns: new[] { "Id", "MalAdi", "MalId", "SatilanMiqdar", "SatisId" },
                values: new object[] { 1, null, 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "SatilmisMallar",
                columns: new[] { "Id", "MalAdi", "MalId", "SatilanMiqdar", "SatisId" },
                values: new object[] { 2, null, 2, 4, 1 });

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
