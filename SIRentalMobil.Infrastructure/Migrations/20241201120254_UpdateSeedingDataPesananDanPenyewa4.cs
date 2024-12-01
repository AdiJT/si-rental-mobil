using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIRentalMobil.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedingDataPesananDanPenyewa4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TanggalAkhirSewa", "TanggalAwalSewa", "TanggalPesan" },
                values: new object[] { new DateTime(2024, 12, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TanggalAkhirSewa", "TanggalAwalSewa" },
                values: new object[] { new DateTime(2024, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TanggalAkhirSewa", "TanggalAwalSewa", "TanggalPesan" },
                values: new object[] { new DateTime(2024, 2, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TanggalAkhirSewa", "TanggalAwalSewa" },
                values: new object[] { new DateTime(2024, 12, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
