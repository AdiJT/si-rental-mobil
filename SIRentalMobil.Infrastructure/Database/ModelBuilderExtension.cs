using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SIRentalMobil.Domain.Entities;
using SIRentalMobil.Domain.Enums;

namespace SIRentalMobil.Infrastructure.Database;

public static class ModelBuilderExtension
{
    public static ModelBuilder SeedingData(this ModelBuilder modelBuilder)
    {
        #region Penyewa
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                NIK = "1234567890123456",
                Nama = "John Doe",
                Alamat = "Jln Perca, Kelurahan Airnona, Kecamatan Kota Raja, Kota Kupang, Nusa Tenggara Timur",
                NoHP = "081234567890",
                Email = "johndoe@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                Role = UserRoles.Penyewa
            }
        );
        #endregion

        #region Pemilik
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 2,
                Nama = "Andi Santoso",
                NIK = "5301011234567890",
                Alamat = "Jl. El Tari, Kupang",
                NoHP = "081234567890",
                Email = "andisantoso@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                Role = UserRoles.Pemilik
            },
            new User
            {
                Id = 3,
                Nama = "Budi Hartono",
                NIK = "5301022234567891",
                Alamat = "Jl. Fatululi, Kupang",
                NoHP = "081345678901",
                Email = "budihartono@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                Role = UserRoles.Pemilik
            },
            new User
            {
                Id = 4,
                Nama = "Citra Puspita",
                NIK = "5301033234567892",
                Alamat = "Jl. Frans Seda, Kupang",
                NoHP = "081456789012",
                Email = "citrapuspita@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                Role = UserRoles.Pemilik
            },
            new User
            {
                Id = 5,
                Nama = "Doni Wahyudi",
                NIK = "5301044234567893",
                Alamat = "Jl. W.J. Lalamentik, Kupang",
                NoHP = "081567890123",
                Email = "doniwahyudi@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                Role = UserRoles.Pemilik
            },
            new User
            {
                Id = 6,
                Nama = "Elisa Anggrek",
                NIK = "5301055234567894",
                Alamat = "Jl. Timor Raya, Kupang",
                NoHP = "081678901234",
                Email = "elisaanggrek@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                Role = UserRoles.Pemilik
            }
        );
        #endregion

        #region MetodePembayaran
        modelBuilder.Entity<MetodePembayaran>().HasData(
            new MetodePembayaran
            {
                Id = 1,
                Nama = "Tunai"
            },
            new MetodePembayaran
            {
                Id = 2,
                Nama = "OVO"
            },
            new MetodePembayaran
            {
                Id = 3,
                Nama = "GoPay"
            },
            new MetodePembayaran
            {
                Id = 4,
                Nama = "Dana"
            },
            new MetodePembayaran
            {
                Id = 5,
                Nama = "QRIS"
            }
        );
        #endregion

        #region Mobil
        modelBuilder.Entity<Mobil>().HasData(
            // Data untuk Pemilik ID 1
            new
            {
                Id = 1,
                Nama = "Toyota Avanza",
                Tarif = 350000d,
                MaksPenumpang = 7,
                LuarKota = true,
                MaksHariSewa = 5,
                Sopir = false,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 1
            },
            new
            {
                Id = 2,
                Nama = "Honda Mobilio",
                Tarif = 400000d,
                MaksPenumpang = 6,
                LuarKota = true,
                MaksHariSewa = 7,
                Sopir = true,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 1
            },
            new
            {
                Id = 3,
                Nama = "Suzuki Ertiga",
                Tarif = 375000d,
                MaksPenumpang = 7,
                LuarKota = false,
                MaksHariSewa = 3,
                Sopir = false,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 1
            },

            // Data untuk Pemilik ID 2
            new
            {
                Id = 4,
                Nama = "Daihatsu Xenia",
                Tarif = 300000d,
                MaksPenumpang = 7,
                LuarKota = true,
                MaksHariSewa = 5,
                Sopir = true,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 2
            },
            new
            {
                Id = 5,
                Nama = "Toyota Fortuner",
                Tarif = 800000d,
                MaksPenumpang = 7,
                LuarKota = true,
                MaksHariSewa = 10,
                Sopir = true,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 2
            },
            new
            {
                Id = 6,
                Nama = "Honda BR-V",
                Tarif = 450000d,
                MaksPenumpang = 5,
                LuarKota = false,
                MaksHariSewa = 4,
                Sopir = false,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 2
            },

            // Data untuk Pemilik ID 3
            new
            {
                Id = 7,
                Nama = "Mitsubishi Pajero",
                Tarif = 850000d,
                MaksPenumpang = 7,
                LuarKota = true,
                MaksHariSewa = 7,
                Sopir = true,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 3
            },
            new
            {
                Id = 8,
                Nama = "Toyota Innova",
                Tarif = 500000d,
                MaksPenumpang = 7,
                LuarKota = true,
                MaksHariSewa = 7,
                Sopir = true,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 3
            },
            new
            {
                Id = 9,
                Nama = "Suzuki Carry",
                Tarif = 250000d,
                MaksPenumpang = 2,
                LuarKota = false,
                MaksHariSewa = 2,
                Sopir = false,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 3
            },

            // Data untuk Pemilik ID 4
            new
            {
                Id = 10,
                Nama = "Hyundai Stargazer",
                Tarif = 450000d,
                MaksPenumpang = 6,
                LuarKota = true,
                MaksHariSewa = 7,
                Sopir = false,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 4
            },
            new
            {
                Id = 11,
                Nama = "Kia Sonet",
                Tarif = 500000d,
                MaksPenumpang = 5,
                LuarKota = true,
                MaksHariSewa = 5,
                Sopir = true,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 4
            },
            new
            {
                Id = 12,
                Nama = "Toyota Rush",
                Tarif = 400000d,
                MaksPenumpang = 7,
                LuarKota = false,
                MaksHariSewa = 4,
                Sopir = false,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 4
            },

            // Data untuk Pemilik ID 5
            new
            {
                Id = 13,
                Nama = "Nissan Livina",
                Tarif = 380000d,
                MaksPenumpang = 7,
                LuarKota = true,
                MaksHariSewa = 6,
                Sopir = false,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 5
            },
            new
            {
                Id = 14,
                Nama = "Toyota Alphard",
                Tarif = 1200000d,
                MaksPenumpang = 7,
                LuarKota = true,
                MaksHariSewa = 10,
                Sopir = true,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 5
            },
            new
            {
                Id = 15,
                Nama = "Honda Jazz",
                Tarif = 350000d,
                MaksPenumpang = 5,
                LuarKota = false,
                MaksHariSewa = 3,
                Sopir = false,
                Status = StatusMobil.Tersedia,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                PemilikId = 5
            }
        );
        #endregion

        return modelBuilder;
    }
}
