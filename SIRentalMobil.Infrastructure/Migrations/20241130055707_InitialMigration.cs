using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false),
                    NoHP = table.Column<string>(type: "text", nullable: false),
                    Alamat = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false)
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

            migrationBuilder.InsertData(
                table: "TblMetodePembayaran",
                columns: new[] { "Id", "Nama" },
                values: new object[,]
                {
                    { 1, "Tunai" },
                    { 2, "OVO" },
                    { 3, "GoPay" },
                    { 4, "Dana" },
                    { 5, "QRIS" }
                });

            migrationBuilder.InsertData(
                table: "TblUser",
                columns: new[] { "Id", "Alamat", "Email", "NIK", "Nama", "NoHP", "PasswordHash", "Role" },
                values: new object[,]
                {
                    { 1, "Jln Perca, Kelurahan Airnona, Kecamatan Kota Raja, Kota Kupang, Nusa Tenggara Timur", "johndoe@gmail.com", "1234567890123456", "John Doe", "081234567890", "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==", "Penyewa" },
                    { 2, "Jl. El Tari, Kupang", "andisantoso@gmail.com", "5301011234567890", "Andi Santoso", "081234567890", "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==", "Pemilik" },
                    { 3, "Jl. Fatululi, Kupang", "budihartono@gmail.com", "5301022234567891", "Budi Hartono", "081345678901", "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==", "Pemilik" },
                    { 4, "Jl. Frans Seda, Kupang", "citrapuspita@gmail.com", "5301033234567892", "Citra Puspita", "081456789012", "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==", "Pemilik" },
                    { 5, "Jl. W.J. Lalamentik, Kupang", "doniwahyudi@gmail.com", "5301044234567893", "Doni Wahyudi", "081567890123", "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==", "Pemilik" },
                    { 6, "Jl. Timor Raya, Kupang", "elisaanggrek@gmail.com", "5301055234567894", "Elisa Anggrek", "081678901234", "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==", "Pemilik" }
                });

            migrationBuilder.InsertData(
                table: "TblMobil",
                columns: new[] { "Id", "LuarKota", "MaksHariSewa", "MaksPenumpang", "Nama", "PemilikId", "Sopir", "Status", "Tarif", "UrlGambar" },
                values: new object[,]
                {
                    { 1, true, 5, 7, "Toyota Avanza", 1, false, 0, 350000.0, "/assets/deals-1.png" },
                    { 2, true, 7, 6, "Honda Mobilio", 1, true, 0, 400000.0, "/assets/deals-1.png" },
                    { 3, false, 3, 7, "Suzuki Ertiga", 1, false, 0, 375000.0, "/assets/deals-1.png" },
                    { 4, true, 5, 7, "Daihatsu Xenia", 2, true, 0, 300000.0, "/assets/deals-1.png" },
                    { 5, true, 10, 7, "Toyota Fortuner", 2, true, 0, 800000.0, "/assets/deals-1.png" },
                    { 6, false, 4, 5, "Honda BR-V", 2, false, 0, 450000.0, "/assets/deals-1.png" },
                    { 7, true, 7, 7, "Mitsubishi Pajero", 3, true, 0, 850000.0, "/assets/deals-1.png" },
                    { 8, true, 7, 7, "Toyota Innova", 3, true, 0, 500000.0, "/assets/deals-1.png" },
                    { 9, false, 2, 2, "Suzuki Carry", 3, false, 0, 250000.0, "/assets/deals-1.png" },
                    { 10, true, 7, 6, "Hyundai Stargazer", 4, false, 0, 450000.0, "/assets/deals-1.png" },
                    { 11, true, 5, 5, "Kia Sonet", 4, true, 0, 500000.0, "/assets/deals-1.png" },
                    { 12, false, 4, 7, "Toyota Rush", 4, false, 0, 400000.0, "/assets/deals-1.png" },
                    { 13, true, 6, 7, "Nissan Livina", 5, false, 0, 380000.0, "/assets/deals-1.png" },
                    { 14, true, 10, 7, "Toyota Alphard", 5, true, 0, 1200000.0, "/assets/deals-1.png" },
                    { 15, false, 3, 5, "Honda Jazz", 5, false, 0, 350000.0, "/assets/deals-1.png" }
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
