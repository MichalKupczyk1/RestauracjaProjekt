using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektTaiib.Migrations
{
    public partial class sqlserver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kelner",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kelner", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stolik",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ileMiejsc = table.Column<int>(type: "int", nullable: false),
                    czyZajety = table.Column<bool>(type: "bit", nullable: false),
                    czyObsluzony = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stolik", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "typDania",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwaTypu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typDania", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "kartaDan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwaDania = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cena = table.Column<float>(type: "real", nullable: false),
                    id_typDania = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kartaDan", x => x.id);
                    table.ForeignKey(
                        name: "FK_kartaDan_typDania_id_typDania",
                        column: x => x.id_typDania,
                        principalTable: "typDania",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "zamowienie",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_stolik = table.Column<int>(type: "int", nullable: false),
                    id_kartaDan = table.Column<int>(type: "int", nullable: false),
                    id_kelner = table.Column<int>(type: "int", nullable: false),
                    data_zam = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zamowienie", x => x.id);
                    table.ForeignKey(
                        name: "FK_zamowienie_kartaDan_id_kartaDan",
                        column: x => x.id_kartaDan,
                        principalTable: "kartaDan",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_zamowienie_kelner_id_kelner",
                        column: x => x.id_kelner,
                        principalTable: "kelner",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_zamowienie_stolik_id_stolik",
                        column: x => x.id_stolik,
                        principalTable: "stolik",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_kartaDan_id_typDania",
                table: "kartaDan",
                column: "id_typDania");

            migrationBuilder.CreateIndex(
                name: "IX_zamowienie_id_kartaDan",
                table: "zamowienie",
                column: "id_kartaDan");

            migrationBuilder.CreateIndex(
                name: "IX_zamowienie_id_kelner",
                table: "zamowienie",
                column: "id_kelner");

            migrationBuilder.CreateIndex(
                name: "IX_zamowienie_id_stolik",
                table: "zamowienie",
                column: "id_stolik");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "zamowienie");

            migrationBuilder.DropTable(
                name: "kartaDan");

            migrationBuilder.DropTable(
                name: "kelner");

            migrationBuilder.DropTable(
                name: "stolik");

            migrationBuilder.DropTable(
                name: "typDania");
        }
    }
}
