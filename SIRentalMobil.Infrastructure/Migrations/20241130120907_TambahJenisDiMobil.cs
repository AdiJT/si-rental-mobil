using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIRentalMobil.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TambahJenisDiMobil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Jenis",
                table: "TblMobil",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 1,
                column: "Jenis",
                value: "Toyota");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 2,
                column: "Jenis",
                value: "Honda");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 3,
                column: "Jenis",
                value: "Suzuki");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 4,
                column: "Jenis",
                value: "Daihatsu");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 5,
                column: "Jenis",
                value: "Toyota");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 6,
                column: "Jenis",
                value: "Honda");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 7,
                column: "Jenis",
                value: "Mitsubishi");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 8,
                column: "Jenis",
                value: "Toyota");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 9,
                column: "Jenis",
                value: "Suzuki");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 10,
                column: "Jenis",
                value: "Hyundai");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 11,
                column: "Jenis",
                value: "Kia");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 12,
                column: "Jenis",
                value: "Toyota");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 13,
                column: "Jenis",
                value: "Nissan");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 14,
                column: "Jenis",
                value: "Toyota");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 15,
                column: "Jenis",
                value: "Honda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Jenis",
                table: "TblMobil");
        }
    }
}
