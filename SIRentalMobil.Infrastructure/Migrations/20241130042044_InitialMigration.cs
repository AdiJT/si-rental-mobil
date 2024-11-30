using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SIRentalMobil.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblMetodePembayaran",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nama = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMetodePembayaran", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NIK = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false),
                    NoHP = table.Column<string>(type: "text", nullable: false),
                    Alamat = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblMobil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    UrlGambar = table.Column<string>(type: "text", nullable: false),
                    Tarif = table.Column<double>(type: "double precision", nullable: false),
                    MaksPenumpang = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    LuarKota = table.Column<bool>(type: "boolean", nullable: false),
                    MaksHariSewa = table.Column<int>(type: "integer", nullable: false),
                    Sopir = table.Column<bool>(type: "boolean", nullable: false),
                    PemilikId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMobil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblMobil_TblUser_PemilikId",
                        column: x => x.PemilikId,
                        principalTable: "TblUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblPesanan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TanggalPesan = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TanggalAwalSewa = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TanggalAkhirSewa = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Sopir = table.Column<bool>(type: "boolean", nullable: false),
                    LuarKota = table.Column<bool>(type: "boolean", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    PenyewaId = table.Column<int>(type: "integer", nullable: false),
                    MobilId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPesanan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblPesanan_TblMobil_MobilId",
                        column: x => x.MobilId,
                        principalTable: "TblMobil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblPesanan_TblUser_PenyewaId",
                        column: x => x.PenyewaId,
                        principalTable: "TblUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblPembayaran",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TanggalBayar = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PesananId = table.Column<int>(type: "integer", nullable: false),
                    MetodePembayaranId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPembayaran", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblPembayaran_TblMetodePembayaran_MetodePembayaranId",
                        column: x => x.MetodePembayaranId,
                        principalTable: "TblMetodePembayaran",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblPembayaran_TblPesanan_PesananId",
                        column: x => x.PesananId,
                        principalTable: "TblPesanan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblMobil_PemilikId",
                table: "TblMobil",
                column: "PemilikId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPembayaran_MetodePembayaranId",
                table: "TblPembayaran",
                column: "MetodePembayaranId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPembayaran_PesananId",
                table: "TblPembayaran",
                column: "PesananId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblPesanan_MobilId",
                table: "TblPesanan",
                column: "MobilId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPesanan_PenyewaId",
                table: "TblPesanan",
                column: "PenyewaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblPembayaran");

            migrationBuilder.DropTable(
                name: "TblMetodePembayaran");

            migrationBuilder.DropTable(
                name: "TblPesanan");

            migrationBuilder.DropTable(
                name: "TblMobil");

            migrationBuilder.DropTable(
                name: "TblUser");
        }
    }
}
