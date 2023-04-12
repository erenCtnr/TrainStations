using System;
using System.Data.Entity;
using System.Linq;


namespace TrenIstasyonuProjesi.Models
{
    public class Kullanici
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }

    public class TrenIstasyonu
    {
        public int IstasyonID { get; set; }
        public string IstasyonAdi { get; set; }
        public string IstasyonAdresi { get; set; }
        public string IstasyonKonumu { get; set; }
    }

    public class TrenSeferi
    {
        public int SeferID { get; set; }
        public int KalkisIstasyonuID { get; set; }
        public int VarisIstasyonuID { get; set; }
        public DateTime KalkisSaati { get; set; }
        public DateTime VarisSaati { get; set; }

        public TrenIstasyonu KalkisIstasyonu { get; set; }
        public TrenIstasyonu VarisIstasyonu { get; set; }
    }
}