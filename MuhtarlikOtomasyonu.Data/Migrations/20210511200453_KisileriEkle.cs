using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MuhtarlikOtomasyonu.Data.Migrations
{
    public partial class KisileriEkle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Adi",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DogumTarihi",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Soyadi",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TCKN",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Adi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DogumTarihi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Soyadi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TCKN",
                table: "AspNetUsers");
        }
    }
}
