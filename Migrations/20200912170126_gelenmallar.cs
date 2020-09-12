using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnbarUchotu.Migrations
{
    public partial class gelenmallar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Istehsal", "SonIstifade" },
                values: new object[] { new DateTime(2020, 9, 12, 21, 1, 26, 166, DateTimeKind.Local).AddTicks(4346), new DateTime(2021, 3, 12, 21, 1, 26, 167, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Istehsal", "SonIstifade" },
                values: new object[] { new DateTime(2020, 9, 12, 21, 1, 26, 167, DateTimeKind.Local).AddTicks(3366), new DateTime(2021, 3, 12, 21, 1, 26, 167, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.CreateIndex(
                name: "IX_GelenMallar_MalId",
                table: "GelenMallar",
                column: "MalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GelenMallar");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Istehsal", "SonIstifade" },
                values: new object[] { new DateTime(2020, 9, 11, 15, 33, 29, 847, DateTimeKind.Local).AddTicks(9280), new DateTime(2021, 3, 11, 15, 33, 29, 848, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Istehsal", "SonIstifade" },
                values: new object[] { new DateTime(2020, 9, 11, 15, 33, 29, 848, DateTimeKind.Local).AddTicks(3337), new DateTime(2021, 3, 11, 15, 33, 29, 848, DateTimeKind.Local).AddTicks(3350) });
        }
    }
}
