using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIRentalMobil.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedingDataPesananDanPenyewa2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 2,
                column: "TanggalAkhirSewa",
                value: new DateTime(2024, 2, 12, 12, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 2,
                column: "TanggalAkhirSewa",
                value: new DateTime(2024, 1, 12, 12, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
