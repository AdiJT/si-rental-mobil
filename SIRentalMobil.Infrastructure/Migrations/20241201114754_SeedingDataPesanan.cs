using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIRentalMobil.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataPesanan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblPesanan",
                columns: new[] { "Id", "LuarKota", "MobilId", "PenyewaId", "Sopir", "Status", "TanggalAkhirSewa", "TanggalAwalSewa", "TanggalPesan" },
                values: new object[] { 1, false, 3, 1, true, 0, new DateTime(2024, 2, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
