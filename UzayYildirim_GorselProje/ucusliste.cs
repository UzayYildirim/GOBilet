using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzayYildirim_GorselProje
{
    public static class ucusliste // Tüm uçuş fonksiyonlarını bulundurur.
    {
        public static List<ucus> gidenucuslar = new List<ucus>();
        public static List<ucus> donenucuslar = new List<ucus>();
        public static List<kullanici> kullanicilar = new List<kullanici>();
        public static ucus gidenucus;
        public static ucus donenucus;
        static Random rnd = new Random();
        public static List<yolcu> yolcular = new List<yolcu>();
        public static List<ucus> ucusdoldur(string kalkisha, string varisha, string tarih, int ksayisi, bool gidisdonus)
        {
            List<ucus> ucuslar = new List<ucus>();
            int bassaat = rnd.Next(9, 12);
            for (int i = 0; i < 3; i++)
            {
                string firmaadi = "";
                int firmano = rnd.Next(1, 5);
                switch (firmano) // Rastgele bulunan firma no'suna göre havayolu firma adını belirler.
                {
                    case 1:
                        firmaadi = "THY";
                        break;
                    case 2:
                        firmaadi = "Pegasus";
                        break;
                    case 3:
                        firmaadi = "AnadoluJet";
                        break;
                    case 4:
                        firmaadi = "SunExpress";
                        break;

                }
                int fiyat = rnd.Next(487, 1232); // Fiyatı rastgele belirler.
                int saat = bassaat + rnd.Next(1, 3);
                bassaat = saat;
                int[] dakikalar = new int[] {10, 25, 30, 35, 45, 55}; // Dakikayı belirli sayılar içinden seçer.
                string ucussaati = saat.ToString() + ":" + dakikalar[rnd.Next(0, 5)].ToString();
                ucus u = new ucus();
                u.firma = firmaadi;
                u.saat = ucussaati;
                u.fiyat = fiyat;
                u.tarih = tarih;
                u.kalkis = kalkisha;
                u.varis = varisha;
                u.gidisdonus = gidisdonus;
                u.ksayisi = ksayisi;
                ucuslar.Add(u);
            }
            return ucuslar;
        }
    }
}
