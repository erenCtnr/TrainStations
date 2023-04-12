using System.ComponentModel.DataAnnotations;

namespace TrenIstasyonuProjesi.Models
{
    public class Kullanici
    {
        public int KullaniciID { get; set; }

        [Required(ErrorMessage = "L�tfen kullan�c� ad�n� girin.")]
        [StringLength(100)]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "L�tfen �ifreyi girin.")]
        [StringLength(200)]
        public string Sifre { get; set; }
    }
}
