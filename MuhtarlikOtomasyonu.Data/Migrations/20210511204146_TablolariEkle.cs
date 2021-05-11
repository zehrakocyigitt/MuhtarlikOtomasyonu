using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MuhtarlikOtomasyonu.Data.Migrations
{
    public partial class TablolariEkle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BelgeTipleri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Adi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BelgeTipleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Muhtarliklar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    MuhtarlikAdi = table.Column<string>(nullable: true),
                    KisiId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muhtarliklar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Muhtarliklar_AspNetUsers_KisiId",
                        column: x => x.KisiId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BelgeTalepleri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    TalepteBulunanKisiId = table.Column<string>(nullable: true),
                    OnaylayanKisiId = table.Column<string>(nullable: true),
                    BelgeTipiId = table.Column<int>(nullable: false),
                    TalepTarihi = table.Column<DateTime>(nullable: false),
                    TalepDetayi = table.Column<string>(nullable: true),
                    TalepOnaylandimi = table.Column<bool>(nullable: true),
                    TalepTamamlandimi = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BelgeTalepleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BelgeTalepleri_BelgeTipleri_BelgeTipiId",
                        column: x => x.BelgeTipiId,
                        principalTable: "BelgeTipleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BelgeTalepleri_AspNetUsers_OnaylayanKisiId",
                        column: x => x.OnaylayanKisiId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BelgeTalepleri_AspNetUsers_TalepteBulunanKisiId",
                        column: x => x.TalepteBulunanKisiId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mahalleler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    MahalleAdi = table.Column<string>(nullable: true),
                    MuhtarlikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mahalleler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mahalleler_Muhtarliklar_MuhtarlikId",
                        column: x => x.MuhtarlikId,
                        principalTable: "Muhtarliklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Caddeler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CaddeAdi = table.Column<string>(nullable: true),
                    MahalleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caddeler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Caddeler_Mahalleler_MahalleId",
                        column: x => x.MahalleId,
                        principalTable: "Mahalleler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sokaklar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SokakAdi = table.Column<string>(nullable: true),
                    CaddeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sokaklar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sokaklar_Caddeler_CaddeId",
                        column: x => x.CaddeId,
                        principalTable: "Caddeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Binalar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    BinaAdi = table.Column<string>(nullable: true),
                    BinaNo = table.Column<int>(nullable: false),
                    SokakId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Binalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Binalar_Sokaklar_SokakId",
                        column: x => x.SokakId,
                        principalTable: "Sokaklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adresler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    BinaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adresler_Binalar_BinaId",
                        column: x => x.BinaId,
                        principalTable: "Binalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdresteOturanKisiler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    AdresId = table.Column<int>(nullable: false),
                    KisiId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdresteOturanKisiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdresteOturanKisiler_Adresler_AdresId",
                        column: x => x.AdresId,
                        principalTable: "Adresler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdresteOturanKisiler_AspNetUsers_KisiId",
                        column: x => x.KisiId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresler_BinaId",
                table: "Adresler",
                column: "BinaId");

            migrationBuilder.CreateIndex(
                name: "IX_AdresteOturanKisiler_AdresId",
                table: "AdresteOturanKisiler",
                column: "AdresId");

            migrationBuilder.CreateIndex(
                name: "IX_AdresteOturanKisiler_KisiId",
                table: "AdresteOturanKisiler",
                column: "KisiId");

            migrationBuilder.CreateIndex(
                name: "IX_BelgeTalepleri_BelgeTipiId",
                table: "BelgeTalepleri",
                column: "BelgeTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_BelgeTalepleri_OnaylayanKisiId",
                table: "BelgeTalepleri",
                column: "OnaylayanKisiId");

            migrationBuilder.CreateIndex(
                name: "IX_BelgeTalepleri_TalepteBulunanKisiId",
                table: "BelgeTalepleri",
                column: "TalepteBulunanKisiId");

            migrationBuilder.CreateIndex(
                name: "IX_Binalar_SokakId",
                table: "Binalar",
                column: "SokakId");

            migrationBuilder.CreateIndex(
                name: "IX_Caddeler_MahalleId",
                table: "Caddeler",
                column: "MahalleId");

            migrationBuilder.CreateIndex(
                name: "IX_Mahalleler_MuhtarlikId",
                table: "Mahalleler",
                column: "MuhtarlikId");

            migrationBuilder.CreateIndex(
                name: "IX_Muhtarliklar_KisiId",
                table: "Muhtarliklar",
                column: "KisiId");

            migrationBuilder.CreateIndex(
                name: "IX_Sokaklar_CaddeId",
                table: "Sokaklar",
                column: "CaddeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdresteOturanKisiler");

            migrationBuilder.DropTable(
                name: "BelgeTalepleri");

            migrationBuilder.DropTable(
                name: "Adresler");

            migrationBuilder.DropTable(
                name: "BelgeTipleri");

            migrationBuilder.DropTable(
                name: "Binalar");

            migrationBuilder.DropTable(
                name: "Sokaklar");

            migrationBuilder.DropTable(
                name: "Caddeler");

            migrationBuilder.DropTable(
                name: "Mahalleler");

            migrationBuilder.DropTable(
                name: "Muhtarliklar");
        }
    }
}
