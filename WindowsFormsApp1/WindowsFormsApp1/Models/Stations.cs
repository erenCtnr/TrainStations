using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrenIstasyonuProjesi.Models
{
    public class Istasyon
    {
        public int IstasyonID { get; set; }

        [Required(ErrorMessage = "L�tfen istasyon ad�n� girin.")]
        [StringLength(100)]
        public string IstasyonAdi { get; set; }

        [Required(ErrorMessage = "L�tfen istasyon adresini girin.")]
        [StringLength(200)]
        public string IstasyonAdresi { get; set; }

        [Required(ErrorMessage = "L�tfen istasyon konumunu girin.")]
        [StringLength(200)]
        public string IstasyonKonumu { get; set; }

        public virtual ICollection<Sefer> KalkisSeferleri { get; set; }
        public virtual ICollection<Sefer> VarisSeferleri
        {
            get; set;
        }
    }
}
