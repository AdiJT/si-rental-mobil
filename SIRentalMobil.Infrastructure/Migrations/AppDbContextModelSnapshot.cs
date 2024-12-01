﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SIRentalMobil.Infrastructure.Database;

#nullable disable

namespace SIRentalMobil.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SIRentalMobil.Domain.Entities.MetodePembayaran", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TblMetodePembayaran");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nama = "Tunai"
                        },
                        new
                        {
                            Id = 2,
                            Nama = "OVO"
                        },
                        new
                        {
                            Id = 3,
                            Nama = "GoPay"
                        },
                        new
                        {
                            Id = 4,
                            Nama = "Dana"
                        },
                        new
                        {
                            Id = 5,
                            Nama = "QRIS"
                        });
                });

            modelBuilder.Entity("SIRentalMobil.Domain.Entities.Mobil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CC")
                        .HasColumnType("integer");

                    b.Property<string>("Dekripsi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Jenis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("JenisBensin")
                        .HasColumnType("integer");

                    b.Property<int>("JenisTransmisi")
                        .HasColumnType("integer");

                    b.Property<bool>("LuarKota")
                        .HasColumnType("boolean");

                    b.Property<int>("MaksHariSewa")
                        .HasColumnType("integer");

                    b.Property<int>("MaksPenumpang")
                        .HasColumnType("integer");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NomorPlat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PemilikId")
                        .HasColumnType("integer");

                    b.Property<bool>("Sopir")
                        .HasColumnType("boolean");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("Tahun")
                        .HasColumnType("integer");

                    b.Property<double>("Tarif")
                        .HasColumnType("double precision");

                    b.Property<string>("UrlGambar")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PemilikId");

                    b.ToTable("TblMobil");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CC = 1500,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Toyota",
                            JenisBensin = 0,
                            JenisTransmisi = 0,
                            LuarKota = true,
                            MaksHariSewa = 7,
                            MaksPenumpang = 7,
                            Nama = "Toyota Avanza",
                            NomorPlat = "DH1234",
                            PemilikId = 2,
                            Sopir = false,
                            Status = 0,
                            Tahun = 2020,
                            Tarif = 450000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 2,
                            CC = 1300,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Honda",
                            JenisBensin = 0,
                            JenisTransmisi = 0,
                            LuarKota = true,
                            MaksHariSewa = 5,
                            MaksPenumpang = 5,
                            Nama = "Honda Jazz",
                            NomorPlat = "DH1234",
                            PemilikId = 2,
                            Sopir = false,
                            Status = 1,
                            Tahun = 2021,
                            Tarif = 400000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 3,
                            CC = 1500,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Mitsubishi",
                            JenisBensin = 1,
                            JenisTransmisi = 0,
                            LuarKota = true,
                            MaksHariSewa = 10,
                            MaksPenumpang = 7,
                            Nama = "Mitsubishi Xpander",
                            NomorPlat = "DH1234",
                            PemilikId = 2,
                            Sopir = true,
                            Status = 1,
                            Tahun = 2019,
                            Tarif = 500000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 4,
                            CC = 1200,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Daihatsu",
                            JenisBensin = 0,
                            JenisTransmisi = 0,
                            LuarKota = false,
                            MaksHariSewa = 5,
                            MaksPenumpang = 7,
                            Nama = "Daihatsu Sigra",
                            NomorPlat = "DH1234",
                            PemilikId = 3,
                            Sopir = false,
                            Status = 0,
                            Tahun = 2022,
                            Tarif = 300000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 5,
                            CC = 1500,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Toyota",
                            JenisBensin = 1,
                            JenisTransmisi = 0,
                            LuarKota = true,
                            MaksHariSewa = 7,
                            MaksPenumpang = 7,
                            Nama = "Toyota Rush",
                            NomorPlat = "DH1234",
                            PemilikId = 3,
                            Sopir = true,
                            Status = 0,
                            Tahun = 2021,
                            Tarif = 600000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 6,
                            CC = 1400,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Suzuki",
                            JenisBensin = 0,
                            JenisTransmisi = 0,
                            LuarKota = true,
                            MaksHariSewa = 6,
                            MaksPenumpang = 7,
                            Nama = "Suzuki Ertiga",
                            NomorPlat = "DH1234",
                            PemilikId = 3,
                            Sopir = false,
                            Status = 0,
                            Tahun = 2020,
                            Tarif = 350000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 7,
                            CC = 2000,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Kijang",
                            JenisBensin = 1,
                            JenisTransmisi = 0,
                            LuarKota = true,
                            MaksHariSewa = 10,
                            MaksPenumpang = 7,
                            Nama = "Kijang Innova",
                            NomorPlat = "DH1234",
                            PemilikId = 4,
                            Sopir = true,
                            Status = 0,
                            Tahun = 2021,
                            Tarif = 700000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 8,
                            CC = 2500,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Toyota",
                            JenisBensin = 1,
                            JenisTransmisi = 0,
                            LuarKota = true,
                            MaksHariSewa = 12,
                            MaksPenumpang = 7,
                            Nama = "Toyota Fortuner",
                            NomorPlat = "DH1234",
                            PemilikId = 4,
                            Sopir = true,
                            Status = 0,
                            Tahun = 2022,
                            Tarif = 1000000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 9,
                            CC = 2400,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Honda",
                            JenisBensin = 0,
                            JenisTransmisi = 0,
                            LuarKota = true,
                            MaksHariSewa = 9,
                            MaksPenumpang = 7,
                            Nama = "Honda CRV",
                            NomorPlat = "DH1234",
                            PemilikId = 4,
                            Sopir = true,
                            Status = 0,
                            Tahun = 2020,
                            Tarif = 900000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 10,
                            CC = 1200,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Daihatsu",
                            JenisBensin = 0,
                            JenisTransmisi = 0,
                            LuarKota = false,
                            MaksHariSewa = 4,
                            MaksPenumpang = 5,
                            Nama = "Daihatsu Ayla",
                            NomorPlat = "DH1234",
                            PemilikId = 5,
                            Sopir = false,
                            Status = 0,
                            Tahun = 2022,
                            Tarif = 250000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 11,
                            CC = 1200,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Toyota",
                            JenisBensin = 0,
                            JenisTransmisi = 0,
                            LuarKota = true,
                            MaksHariSewa = 5,
                            MaksPenumpang = 5,
                            Nama = "Toyota Agya",
                            NomorPlat = "DH1234",
                            PemilikId = 5,
                            Sopir = false,
                            Status = 0,
                            Tahun = 2021,
                            Tarif = 270000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 12,
                            CC = 1500,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Honda",
                            JenisBensin = 0,
                            JenisTransmisi = 0,
                            LuarKota = true,
                            MaksHariSewa = 6,
                            MaksPenumpang = 7,
                            Nama = "Honda Mobilio",
                            NomorPlat = "DH1234",
                            PemilikId = 5,
                            Sopir = false,
                            Status = 0,
                            Tahun = 2020,
                            Tarif = 350000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 13,
                            CC = 2800,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Toyota",
                            JenisBensin = 1,
                            JenisTransmisi = 0,
                            LuarKota = true,
                            MaksHariSewa = 15,
                            MaksPenumpang = 15,
                            Nama = "Toyota HiAce",
                            NomorPlat = "DH1234",
                            PemilikId = 6,
                            Sopir = true,
                            Status = 0,
                            Tahun = 2019,
                            Tarif = 1200000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 14,
                            CC = 3000,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Isuzu",
                            JenisBensin = 1,
                            JenisTransmisi = 0,
                            LuarKota = true,
                            MaksHariSewa = 14,
                            MaksPenumpang = 16,
                            Nama = "Isuzu Elf",
                            NomorPlat = "DH1234",
                            PemilikId = 6,
                            Sopir = true,
                            Status = 0,
                            Tahun = 2020,
                            Tarif = 1300000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 15,
                            CC = 1500,
                            Dekripsi = "Mobil bersih, wangi, fit untuk segala medan dan di pandu dengan driver/supir yg ramah, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                            Jenis = "Suzuki",
                            JenisBensin = 0,
                            JenisTransmisi = 0,
                            LuarKota = true,
                            MaksHariSewa = 7,
                            MaksPenumpang = 7,
                            Nama = "Suzuki APV",
                            NomorPlat = "DH1234",
                            PemilikId = 6,
                            Sopir = false,
                            Status = 0,
                            Tahun = 2021,
                            Tarif = 500000.0,
                            UrlGambar = "/assets/deals-1.png"
                        });
                });

            modelBuilder.Entity("SIRentalMobil.Domain.Entities.Pembayaran", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MetodePembayaranId")
                        .HasColumnType("integer");

                    b.Property<int>("PesananId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TanggalBayar")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("MetodePembayaranId");

                    b.HasIndex("PesananId")
                        .IsUnique();

                    b.ToTable("TblPembayaran");
                });

            modelBuilder.Entity("SIRentalMobil.Domain.Entities.Pesanan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("LuarKota")
                        .HasColumnType("boolean");

                    b.Property<int>("MobilId")
                        .HasColumnType("integer");

                    b.Property<int>("PenyewaId")
                        .HasColumnType("integer");

                    b.Property<bool>("Sopir")
                        .HasColumnType("boolean");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TanggalAkhirSewa")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("TanggalAwalSewa")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("TanggalPesan")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("MobilId");

                    b.HasIndex("PenyewaId");

                    b.ToTable("TblPesanan");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LuarKota = false,
                            MobilId = 3,
                            PenyewaId = 1,
                            Sopir = true,
                            Status = 0,
                            TanggalAkhirSewa = new DateTime(2024, 12, 4, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            TanggalAwalSewa = new DateTime(2024, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            TanggalPesan = new DateTime(2024, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            LuarKota = false,
                            MobilId = 2,
                            PenyewaId = 7,
                            Sopir = false,
                            Status = 2,
                            TanggalAkhirSewa = new DateTime(2024, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            TanggalAwalSewa = new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            TanggalPesan = new DateTime(2024, 11, 30, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            LuarKota = false,
                            MobilId = 1,
                            PenyewaId = 8,
                            Sopir = false,
                            Status = 2,
                            TanggalAkhirSewa = new DateTime(2024, 11, 30, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            TanggalAwalSewa = new DateTime(2024, 11, 29, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            TanggalPesan = new DateTime(2024, 11, 28, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("SIRentalMobil.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NIK")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NoHP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TblUser");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alamat = "Jln Perca, Kelurahan Airnona, Kecamatan Kota Raja, Kota Kupang, Nusa Tenggara Timur",
                            Email = "johndoe@gmail.com",
                            NIK = "1234567890123456",
                            Nama = "John Doe",
                            NoHP = "081234567890",
                            PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                            Role = "Penyewa"
                        },
                        new
                        {
                            Id = 7,
                            Alamat = "Jln Perca, Kelurahan Airnona, Kecamatan Kota Raja, Kota Kupang, Nusa Tenggara Timur",
                            Email = "johndoe2@gmail.com",
                            NIK = "1234567890123455",
                            Nama = "John Doe 2",
                            NoHP = "081234567890",
                            PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                            Role = "Penyewa"
                        },
                        new
                        {
                            Id = 8,
                            Alamat = "Jln Perca, Kelurahan Airnona, Kecamatan Kota Raja, Kota Kupang, Nusa Tenggara Timur",
                            Email = "johndoe3@gmail.com",
                            NIK = "1234567890123459",
                            Nama = "John Doe 3",
                            NoHP = "081234567890",
                            PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                            Role = "Penyewa"
                        },
                        new
                        {
                            Id = 2,
                            Alamat = "Jl. El Tari, Kupang",
                            Email = "andisantoso@gmail.com",
                            NIK = "5301011234567890",
                            Nama = "Andi Santoso",
                            NoHP = "081234567890",
                            PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                            Role = "Pemilik"
                        },
                        new
                        {
                            Id = 3,
                            Alamat = "Jl. Fatululi, Kupang",
                            Email = "budihartono@gmail.com",
                            NIK = "5301022234567891",
                            Nama = "Budi Hartono",
                            NoHP = "081345678901",
                            PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                            Role = "Pemilik"
                        },
                        new
                        {
                            Id = 4,
                            Alamat = "Jl. Frans Seda, Kupang",
                            Email = "citrapuspita@gmail.com",
                            NIK = "5301033234567892",
                            Nama = "Citra Puspita",
                            NoHP = "081456789012",
                            PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                            Role = "Pemilik"
                        },
                        new
                        {
                            Id = 5,
                            Alamat = "Jl. W.J. Lalamentik, Kupang",
                            Email = "doniwahyudi@gmail.com",
                            NIK = "5301044234567893",
                            Nama = "Doni Wahyudi",
                            NoHP = "081567890123",
                            PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                            Role = "Pemilik"
                        },
                        new
                        {
                            Id = 6,
                            Alamat = "Jl. Timor Raya, Kupang",
                            Email = "elisaanggrek@gmail.com",
                            NIK = "5301055234567894",
                            Nama = "Elisa Anggrek",
                            NoHP = "081678901234",
                            PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                            Role = "Pemilik"
                        });
                });

            modelBuilder.Entity("SIRentalMobil.Domain.Entities.Mobil", b =>
                {
                    b.HasOne("SIRentalMobil.Domain.Entities.User", "Pemilik")
                        .WithMany("DaftarMobil")
                        .HasForeignKey("PemilikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pemilik");
                });

            modelBuilder.Entity("SIRentalMobil.Domain.Entities.Pembayaran", b =>
                {
                    b.HasOne("SIRentalMobil.Domain.Entities.MetodePembayaran", "MetodePembayaran")
                        .WithMany()
                        .HasForeignKey("MetodePembayaranId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SIRentalMobil.Domain.Entities.Pesanan", "Pesanan")
                        .WithOne("Pembayaran")
                        .HasForeignKey("SIRentalMobil.Domain.Entities.Pembayaran", "PesananId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MetodePembayaran");

                    b.Navigation("Pesanan");
                });

            modelBuilder.Entity("SIRentalMobil.Domain.Entities.Pesanan", b =>
                {
                    b.HasOne("SIRentalMobil.Domain.Entities.Mobil", "Mobil")
                        .WithMany("DaftarPesanan")
                        .HasForeignKey("MobilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SIRentalMobil.Domain.Entities.User", "Penyewa")
                        .WithMany("DaftarPesanan")
                        .HasForeignKey("PenyewaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mobil");

                    b.Navigation("Penyewa");
                });

            modelBuilder.Entity("SIRentalMobil.Domain.Entities.Mobil", b =>
                {
                    b.Navigation("DaftarPesanan");
                });

            modelBuilder.Entity("SIRentalMobil.Domain.Entities.Pesanan", b =>
                {
                    b.Navigation("Pembayaran");
                });

            modelBuilder.Entity("SIRentalMobil.Domain.Entities.User", b =>
                {
                    b.Navigation("DaftarMobil");

                    b.Navigation("DaftarPesanan");
                });
#pragma warning restore 612, 618
        }
    }
}
