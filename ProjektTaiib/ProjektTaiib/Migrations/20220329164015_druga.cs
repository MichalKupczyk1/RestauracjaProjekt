using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektTaiib.Migrations
{
    public partial class druga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kartaDan_typDania_id_typDania",
                table: "kartaDan");

            migrationBuilder.DropForeignKey(
                name: "FK_zamowienie_kartaDan_id_kartaDan",
                table: "zamowienie");

            migrationBuilder.DropForeignKey(
                name: "FK_zamowienie_kelner_id_kelner",
                table: "zamowienie");

            migrationBuilder.DropForeignKey(
                name: "FK_zamowienie_stolik_id_stolik",
                table: "zamowienie");

            migrationBuilder.AlterColumn<int>(
                name: "id_stolik",
                table: "zamowienie",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_kelner",
                table: "zamowienie",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_kartaDan",
                table: "zamowienie",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "data_zam",
                table: "zamowienie",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<int>(
                name: "id_typDania",
                table: "kartaDan",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_kartaDan_typDania_id_typDania",
                table: "kartaDan",
                column: "id_typDania",
                principalTable: "typDania",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_zamowienie_kartaDan_id_kartaDan",
                table: "zamowienie",
                column: "id_kartaDan",
                principalTable: "kartaDan",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_zamowienie_kelner_id_kelner",
                table: "zamowienie",
                column: "id_kelner",
                principalTable: "kelner",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_zamowienie_stolik_id_stolik",
                table: "zamowienie",
                column: "id_stolik",
                principalTable: "stolik",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kartaDan_typDania_id_typDania",
                table: "kartaDan");

            migrationBuilder.DropForeignKey(
                name: "FK_zamowienie_kartaDan_id_kartaDan",
                table: "zamowienie");

            migrationBuilder.DropForeignKey(
                name: "FK_zamowienie_kelner_id_kelner",
                table: "zamowienie");

            migrationBuilder.DropForeignKey(
                name: "FK_zamowienie_stolik_id_stolik",
                table: "zamowienie");

            migrationBuilder.AlterColumn<int>(
                name: "id_stolik",
                table: "zamowienie",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "id_kelner",
                table: "zamowienie",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "id_kartaDan",
                table: "zamowienie",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "data_zam",
                table: "zamowienie",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_typDania",
                table: "kartaDan",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_kartaDan_typDania_id_typDania",
                table: "kartaDan",
                column: "id_typDania",
                principalTable: "typDania",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_zamowienie_kartaDan_id_kartaDan",
                table: "zamowienie",
                column: "id_kartaDan",
                principalTable: "kartaDan",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_zamowienie_kelner_id_kelner",
                table: "zamowienie",
                column: "id_kelner",
                principalTable: "kelner",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_zamowienie_stolik_id_stolik",
                table: "zamowienie",
                column: "id_stolik",
                principalTable: "stolik",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
