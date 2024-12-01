using SIRentalMobil.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SIRentalMobil.Web.Models.MobilModels;

public class TambahVM
{
    [Display(Name = "Nama Mobil")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Nama { get; set; } = string.Empty;

    [Display(Name = "Merk Mobil")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Jenis { get; set; } = string.Empty;

    [Display(Name = "CC")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public int CC { get; set; }

    [Display(Name = "Tahun Produksi")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public int Tahun { get; set; }

    [Display(Name = "Nomor Plat")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string NomorPlat { get; set; } = string.Empty;

    [Display(Name = "Tipe Transmisi")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public JenisTransmisi JenisTransmisi { get; set; }

    [Display(Name = "Tipe Bensin")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public JenisBensin JenisBensin { get; set; }

    [Display(Name = "Foto Mobil")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public IFormFile FotoMobil { get; set; }

    [Display(Name = "Tarif/Hari")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public double Tarif { get; set; }

    [Display(Name = "Maksimal Penumpang")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public int MaksPenumpang { get; set; }

    [Display(Name = "Dekripsi Tambahan")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Dekripsi { get; set; }

    [Display(Name = "Maksimal Hari Sewa")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public int MaksHariSewa { get; set; }

    [Display(Name = "Luar Kota")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public bool LuarKota { get; set; }

    [Display(Name = "Fasilitas Sopir")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public bool Sopir { get; set; }
}
