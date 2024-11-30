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
    [Migration("20241130042044_InitialMigration")]
    partial class InitialMigration
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
                });

            modelBuilder.Entity("SIRentalMobil.Domain.Entities.Mobil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

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

                    b.Property<string>("NIK")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NoHP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TblUser");
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
