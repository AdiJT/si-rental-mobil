﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SIRentalMobil.Infrastructure.Database;

#nullable disable

namespace SIRentalMobil.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241130120907_TambahJenisDiMobil")]
    partial class TambahJenisDiMobil
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Jenis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LuarKota")
                        .HasColumnType("boolean");

                    b.Property<int>("MaksHariSewa")
                        .HasColumnType("integer");

                    b.Property<int>("MaksPenumpang")
                        .HasColumnType("integer");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PemilikId")
                        .HasColumnType("integer");

                    b.Property<bool>("Sopir")
                        .HasColumnType("boolean");

                    b.Property<int>("Status")
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
                            Jenis = "Toyota",
                            LuarKota = true,
                            MaksHariSewa = 5,
                            MaksPenumpang = 7,
                            Nama = "Toyota Avanza",
                            PemilikId = 1,
                            Sopir = false,
                            Status = 0,
                            Tarif = 350000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 2,
                            Jenis = "Honda",
                            LuarKota = true,
                            MaksHariSewa = 7,
                            MaksPenumpang = 6,
                            Nama = "Honda Mobilio",
                            PemilikId = 1,
                            Sopir = true,
                            Status = 0,
                            Tarif = 400000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 3,
                            Jenis = "Suzuki",
                            LuarKota = false,
                            MaksHariSewa = 3,
                            MaksPenumpang = 7,
                            Nama = "Suzuki Ertiga",
                            PemilikId = 1,
                            Sopir = false,
                            Status = 0,
                            Tarif = 375000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 4,
                            Jenis = "Daihatsu",
                            LuarKota = true,
                            MaksHariSewa = 5,
                            MaksPenumpang = 7,
                            Nama = "Daihatsu Xenia",
                            PemilikId = 2,
                            Sopir = true,
                            Status = 0,
                            Tarif = 300000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 5,
                            Jenis = "Toyota",
                            LuarKota = true,
                            MaksHariSewa = 10,
                            MaksPenumpang = 7,
                            Nama = "Toyota Fortuner",
                            PemilikId = 2,
                            Sopir = true,
                            Status = 0,
                            Tarif = 800000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 6,
                            Jenis = "Honda",
                            LuarKota = false,
                            MaksHariSewa = 4,
                            MaksPenumpang = 5,
                            Nama = "Honda BR-V",
                            PemilikId = 2,
                            Sopir = false,
                            Status = 0,
                            Tarif = 450000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 7,
                            Jenis = "Mitsubishi",
                            LuarKota = true,
                            MaksHariSewa = 7,
                            MaksPenumpang = 7,
                            Nama = "Mitsubishi Pajero",
                            PemilikId = 3,
                            Sopir = true,
                            Status = 0,
                            Tarif = 850000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 8,
                            Jenis = "Toyota",
                            LuarKota = true,
                            MaksHariSewa = 7,
                            MaksPenumpang = 7,
                            Nama = "Toyota Innova",
                            PemilikId = 3,
                            Sopir = true,
                            Status = 0,
                            Tarif = 500000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 9,
                            Jenis = "Suzuki",
                            LuarKota = false,
                            MaksHariSewa = 2,
                            MaksPenumpang = 2,
                            Nama = "Suzuki Carry",
                            PemilikId = 3,
                            Sopir = false,
                            Status = 0,
                            Tarif = 250000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 10,
                            Jenis = "Hyundai",
                            LuarKota = true,
                            MaksHariSewa = 7,
                            MaksPenumpang = 6,
                            Nama = "Hyundai Stargazer",
                            PemilikId = 4,
                            Sopir = false,
                            Status = 0,
                            Tarif = 450000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 11,
                            Jenis = "Kia",
                            LuarKota = true,
                            MaksHariSewa = 5,
                            MaksPenumpang = 5,
                            Nama = "Kia Sonet",
                            PemilikId = 4,
                            Sopir = true,
                            Status = 0,
                            Tarif = 500000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 12,
                            Jenis = "Toyota",
                            LuarKota = false,
                            MaksHariSewa = 4,
                            MaksPenumpang = 7,
                            Nama = "Toyota Rush",
                            PemilikId = 4,
                            Sopir = false,
                            Status = 0,
                            Tarif = 400000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 13,
                            Jenis = "Nissan",
                            LuarKota = true,
                            MaksHariSewa = 6,
                            MaksPenumpang = 7,
                            Nama = "Nissan Livina",
                            PemilikId = 5,
                            Sopir = false,
                            Status = 0,
                            Tarif = 380000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 14,
                            Jenis = "Toyota",
                            LuarKota = true,
                            MaksHariSewa = 10,
                            MaksPenumpang = 7,
                            Nama = "Toyota Alphard",
                            PemilikId = 5,
                            Sopir = true,
                            Status = 0,
                            Tarif = 1200000.0,
                            UrlGambar = "/assets/deals-1.png"
                        },
                        new
                        {
                            Id = 15,
                            Jenis = "Honda",
                            LuarKota = false,
                            MaksHariSewa = 3,
                            MaksPenumpang = 5,
                            Nama = "Honda Jazz",
                            PemilikId = 5,
                            Sopir = false,
                            Status = 0,
                            Tarif = 350000.0,
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
