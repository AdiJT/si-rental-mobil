using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIRentalMobil.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TambahBanyakDiMobil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CC",
                table: "TblMobil",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JenisBensin",
                table: "TblMobil",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tahun",
                table: "TblMobil",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CC", "Jenis", "JenisBensin", "MaksHariSewa", "Tahun", "Tarif" },
                values: new object[] { 1500, "MPV", 0, 7, 2020, 450000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CC", "Jenis", "JenisBensin", "MaksHariSewa", "MaksPenumpang", "Nama", "Sopir", "Tahun" },
                values: new object[] { 1300, "Hatchback", 0, 5, 5, "Honda Jazz", false, 2021 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CC", "Jenis", "JenisBensin", "LuarKota", "MaksHariSewa", "Nama", "Sopir", "Tahun", "Tarif" },
                values: new object[] { 1500, "MPV", 1, true, 10, "Mitsubishi Xpander", true, 2019, 500000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CC", "Jenis", "JenisBensin", "LuarKota", "Nama", "Sopir", "Tahun" },
                values: new object[] { 1200, "LMPV", 0, false, "Daihatsu Sigra", false, 2022 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CC", "Jenis", "JenisBensin", "MaksHariSewa", "Nama", "Tahun", "Tarif" },
                values: new object[] { 1500, "SUV", 1, 7, "Toyota Rush", 2021, 600000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CC", "Jenis", "JenisBensin", "LuarKota", "MaksHariSewa", "MaksPenumpang", "Nama", "Tahun", "Tarif" },
                values: new object[] { 1400, "MPV", 0, true, 6, 7, "Suzuki Ertiga", 2020, 350000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CC", "Jenis", "JenisBensin", "MaksHariSewa", "Nama", "Tahun", "Tarif" },
                values: new object[] { 2000, "MPV", 1, 10, "Kijang Innova", 2021, 700000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CC", "Jenis", "JenisBensin", "MaksHariSewa", "Nama", "Tahun", "Tarif" },
                values: new object[] { 2500, "SUV", 1, 12, "Toyota Fortuner", 2022, 1000000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CC", "Jenis", "JenisBensin", "LuarKota", "MaksHariSewa", "MaksPenumpang", "Nama", "Sopir", "Tahun", "Tarif" },
                values: new object[] { 2400, "SUV", 0, true, 9, 7, "Honda CRV", true, 2020, 900000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CC", "Jenis", "JenisBensin", "LuarKota", "MaksHariSewa", "MaksPenumpang", "Nama", "Tahun", "Tarif" },
                values: new object[] { 1200, "Hatchback", 0, false, 4, 5, "Daihatsu Ayla", 2022, 250000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CC", "Jenis", "JenisBensin", "Nama", "Sopir", "Tahun", "Tarif" },
                values: new object[] { 1200, "Hatchback", 0, "Toyota Agya", false, 2021, 270000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CC", "Jenis", "JenisBensin", "LuarKota", "MaksHariSewa", "Nama", "Tahun", "Tarif" },
                values: new object[] { 1500, "MPV", 0, true, 6, "Honda Mobilio", 2020, 350000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CC", "Jenis", "JenisBensin", "MaksHariSewa", "MaksPenumpang", "Nama", "Sopir", "Tahun", "Tarif" },
                values: new object[] { 2800, "Van", 1, 15, 15, "Toyota HiAce", true, 2019, 1200000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CC", "Jenis", "JenisBensin", "MaksHariSewa", "MaksPenumpang", "Nama", "Tahun", "Tarif" },
                values: new object[] { 3000, "Van", 1, 14, 16, "Isuzu Elf", 2020, 1300000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CC", "Jenis", "JenisBensin", "LuarKota", "MaksHariSewa", "MaksPenumpang", "Nama", "Tahun", "Tarif" },
                values: new object[] { 1500, "MPV", 0, true, 7, 7, "Suzuki APV", 2021, 500000.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CC",
                table: "TblMobil");

            migrationBuilder.DropColumn(
                name: "JenisBensin",
                table: "TblMobil");

            migrationBuilder.DropColumn(
                name: "Tahun",
                table: "TblMobil");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Jenis", "MaksHariSewa", "Tarif" },
                values: new object[] { "Toyota", 5, 350000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Jenis", "MaksHariSewa", "MaksPenumpang", "Nama", "Sopir" },
                values: new object[] { "Honda", 7, 6, "Honda Mobilio", true });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Jenis", "LuarKota", "MaksHariSewa", "Nama", "Sopir", "Tarif" },
                values: new object[] { "Suzuki", false, 3, "Suzuki Ertiga", false, 375000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Jenis", "LuarKota", "Nama", "Sopir" },
                values: new object[] { "Daihatsu", true, "Daihatsu Xenia", true });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Jenis", "MaksHariSewa", "Nama", "Tarif" },
                values: new object[] { "Toyota", 10, "Toyota Fortuner", 800000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Jenis", "LuarKota", "MaksHariSewa", "MaksPenumpang", "Nama", "Tarif" },
                values: new object[] { "Honda", false, 4, 5, "Honda BR-V", 450000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Jenis", "MaksHariSewa", "Nama", "Tarif" },
                values: new object[] { "Mitsubishi", 7, "Mitsubishi Pajero", 850000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Jenis", "MaksHariSewa", "Nama", "Tarif" },
                values: new object[] { "Toyota", 7, "Toyota Innova", 500000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Jenis", "LuarKota", "MaksHariSewa", "MaksPenumpang", "Nama", "Sopir", "Tarif" },
                values: new object[] { "Suzuki", false, 2, 2, "Suzuki Carry", false, 250000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Jenis", "LuarKota", "MaksHariSewa", "MaksPenumpang", "Nama", "Tarif" },
                values: new object[] { "Hyundai", true, 7, 6, "Hyundai Stargazer", 450000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Jenis", "Nama", "Sopir", "Tarif" },
                values: new object[] { "Kia", "Kia Sonet", true, 500000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Jenis", "LuarKota", "MaksHariSewa", "Nama", "Tarif" },
                values: new object[] { "Toyota", false, 4, "Toyota Rush", 400000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Jenis", "MaksHariSewa", "MaksPenumpang", "Nama", "Sopir", "Tarif" },
                values: new object[] { "Nissan", 6, 7, "Nissan Livina", false, 380000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Jenis", "MaksHariSewa", "MaksPenumpang", "Nama", "Tarif" },
                values: new object[] { "Toyota", 10, 7, "Toyota Alphard", 1200000.0 });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Jenis", "LuarKota", "MaksHariSewa", "MaksPenumpang", "Nama", "Tarif" },
                values: new object[] { "Honda", false, 3, 5, "Honda Jazz", 350000.0 });
        }
    }
}
