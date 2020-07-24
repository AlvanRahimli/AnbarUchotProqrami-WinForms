using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnbarUchotu.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MalAdi = table.Column<string>(nullable: true),
                    Qablasma = table.Column<string>(nullable: true),
                    Miqdar = table.Column<int>(nullable: false),
                    BirEdedinQiymeti = table.Column<int>(nullable: false),
                    YekunQiymet = table.Column<int>(nullable: false),
                    Istehsal = table.Column<DateTime>(nullable: false),
                    SonIstifade = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirEdedinQiymeti", "Istehsal", "MalAdi", "Miqdar", "Qablasma", "SonIstifade", "YekunQiymet" },
                values: new object[] { 1, 150, new DateTime(2020, 7, 23, 23, 38, 33, 668, DateTimeKind.Local).AddTicks(5479), "test mal", 2, "100 ml", new DateTime(2021, 1, 23, 23, 38, 33, 669, DateTimeKind.Local).AddTicks(8142), 300 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirEdedinQiymeti", "Istehsal", "MalAdi", "Miqdar", "Qablasma", "SonIstifade", "YekunQiymet" },
                values: new object[] { 2, 12, new DateTime(2020, 7, 23, 23, 38, 33, 669, DateTimeKind.Local).AddTicks(9771), "test mal 2", 4, "50 ml", new DateTime(2021, 1, 23, 23, 38, 33, 669, DateTimeKind.Local).AddTicks(9786), 48 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
