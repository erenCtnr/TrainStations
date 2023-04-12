using System.ComponentModel.DataAnnotations;

namespace TrenIstasyonuProjesi.Models
{
    public class Kullanici
    {
        public int KullaniciID { get; set; }

        [Required(ErrorMessage = "Lütfen kullanýcý adýný girin.")]
        [StringLength(100)]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "Lütfen þifreyi girin.")]
        [StringLength(200)]
        public string Sifre { get; set; }
    }
}
