using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIRentalMobil.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TambahBanyakDiMobil2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Dekripsi",
                table: "TblMobil",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "JenisTransmisi",
                table: "TblMobil",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NomorPlat",
                table: "TblMobil",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Dekripsi", "JenisTransmisi", "NomorPlat" },
                values: new object[] { "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ", 0, "DH1234" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dekripsi",
                table: "TblMobil");

            migrationBuilder.DropColumn(
                name: "JenisTransmisi",
                table: "TblMobil");

            migrationBuilder.DropColumn(
                name: "NomorPlat",
                table: "TblMobil");
        }
    }
}
