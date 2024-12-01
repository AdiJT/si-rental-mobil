using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIRentalMobil.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedingDataPesananDanPenyewa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblUser",
                columns: new[] { "Id", "Alamat", "Email", "NIK", "Nama", "NoHP", "PasswordHash", "Role" },
                values: new object[,]
                {
                    { 7, "Jln Perca, Kelurahan Airnona, Kecamatan Kota Raja, Kota Kupang, Nusa Tenggara Timur", "johndoe2@gmail.com", "1234567890123455", "John Doe 2", "081234567890", "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==", "Penyewa" },
                    { 8, "Jln Perca, Kelurahan Airnona, Kecamatan Kota Raja, Kota Kupang, Nusa Tenggara Timur", "johndoe3@gmail.com", "1234567890123459", "John Doe 3", "081234567890", "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==", "Penyewa" }
                });

            migrationBuilder.InsertData(
                table: "TblPesanan",
                columns: new[] { "Id", "LuarKota", "MobilId", "PenyewaId", "Sopir", "Status", "TanggalAkhirSewa", "TanggalAwalSewa", "TanggalPesan" },
                values: new object[,]
                {
                    { 2, false, 2, 7, false, 2, new DateTime(2024, 1, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, false, 1, 8, false, 2, new DateTime(2024, 11, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
