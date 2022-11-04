using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorExample1.Models
{
    public static class Veritabani
    {
        private static List<Siparis> _liste;

        static Veritabani()
        {
            _liste = new List<Siparis>
            {
                new Siparis(){UrunId=4, SiparisAdi="Bulaşık Makinesi", Aciklama="BM 5045 I 5 Programlı Inox Bulaşık Makinesi",KargoUcreti=199.90,Satistami=true,Resim="4.jpg"},
                new Siparis(){UrunId=9, SiparisAdi="Telefon", Aciklama="APPLE iPhone 13 128 GB Akıllı Telefon Starlight",KargoUcreti=9.90,Satistami=false,Resim="9.jpg"},
                new Siparis(){UrunId=2, SiparisAdi="Ayakkabı", Aciklama="Nike Court Borough Low 2, rahatlık ve şıklığı bir araya getiriyor!",KargoUcreti=129.90,Satistami=true,Resim="2.jpg"},
                new Siparis(){UrunId=7, SiparisAdi="Saat", Aciklama="Quartz-Pilli  Makine Tipi - Safir Kristal  Cam Tipi - 10 atm  Su Geçirmezlik!",KargoUcreti=49.90,Satistami=true,Resim="7.jpg"},
                new Siparis(){UrunId=3, SiparisAdi="Belgeler", Aciklama="e-fatura, ön muhasebe, pazar yeri entegrasyonları ile satışlarınızı kolayca faturalandırın.",KargoUcreti=39.90,Satistami=false,Resim="3.jpg"},
                new Siparis(){UrunId=6, SiparisAdi="Mutfak", Aciklama="Karaca ile Yeniliğe Açıl. Avantajlı Fiyatlardan Şimdi Yararlanın. Yaz Enerjisi İle Ruhunuzu, Karaca ile Evinizi Yenilemenin Tam Zamanı. Ücretsiz İade. Güvenli Alışveriş. Hızlı Kargo.",KargoUcreti=299.90,Satistami=true,Resim="6.jpg"},
                new Siparis(){UrunId=8, SiparisAdi="Salon", Aciklama="İstikbal Salon Takımları Set Şeklinde Mobilya Ve Vitrin Çeşitleriyle...",KargoUcreti=579.90,Satistami=true,Resim="8.jpg"},
                new Siparis(){UrunId=1, SiparisAdi="Araç Gereç", Aciklama="Elektrik-elektronik araç gereçleri uygun fiyat, taksit ve kapıda ödeme seçenekleri ile Robolink Market'te! Siparişler aynı gün kargoda, bu fırsatı kaçırma!",KargoUcreti=59.90,Satistami=true,Resim="1.jpg"},
                new Siparis(){UrunId=5, SiparisAdi="Matkap", Aciklama="morponi Maxstar 24 V 5ah Liion Çift Akülü Çantalı Darbesiz Şarjlı Matkap...",KargoUcreti=99.90,Satistami=true,Resim="5.jpg"},
            };
        }

        public static List<Siparis> Liste
        {
            get { return _liste; }
        }

        public static void ElemanEkle (Siparis entity)
        {
            _liste.Add(entity);
        }

        public static Siparis SiparisDetay(int siparisid)
        {
            Siparis entity = null;
            foreach (var siparis in _liste)
            {
                if (siparis.UrunId == siparisid)
                {
                    entity = siparis;
                }
            }
            return entity;
        }
    }
}