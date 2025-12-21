namespace Hafta_9_Slayt
{
    internal class Program
    {
        static int[] fiyatlar = { 30, 10, 5 };
        static string[] urunler = { "Tost", "Ayran", "Çay" };
        static void MenuGoster()
        {
            Console.WriteLine("1 - Tost (30 TL)");
            Console.WriteLine("2 - Ayran (10 TL)");
            Console.WriteLine("3 - Çay (5 TL)");
        }
        static int SecimAl()
        {
            Console.WriteLine("Seçiminizi yapınız(1, 2, 3):");
            string secim = Console.ReadLine();

            while (secim != "1" && secim != "2" && secim != "3")
            {
                Console.WriteLine("Yanlış seçim yaptınuz, lütfen tekrar deneyiniz.");
                secim = Console.ReadLine();
            }
            return Convert.ToInt32(secim);
        }
        static int AdetAl()
        {
            Console.WriteLine("Adet sayısını giriniz:");
            int adet = Convert.ToInt32(Console.ReadLine());
            while (adet < 0)
            {
                Console.WriteLine("Hatalı giriş,lütfen tekrar giriniz.");
                adet = Convert.ToInt32(Console.ReadLine());
            }
            return adet;
        }
        static int FiyatGetir(int urunKodu)
        {
            return fiyatlar[urunKodu - 1];
        }
        static int SatırTutarıHesapla(int adet, int birimFiyat)
        {
            return adet * birimFiyat;
        }
        static bool IndirimHakkiVarMi(int toplamTutar)
        {
            if (toplamTutar > 100)
                return true;
            else
                return false;
        }
        static double IndirimliTutarıHesapla(int toplamTutar)
        {
            if (IndirimHakkiVarMi(toplamTutar))
            {
                return toplamTutar * 0.9;
            }
            else
                return toplamTutar;
        }
        static void Yazdır(int secim, int adet, int fiyat, int toplamTutar, bool indirimVarMi, double sonTutar)
        {
            Console.WriteLine("Müşterinin seçtiği ürün :");
            Console.WriteLine("Ürünün adı :" + urunler[secim - 1]);
            Console.WriteLine("Adet :" + adet);
            Console.WriteLine("Fiyat :" + fiyat);
            Console.WriteLine("Toplam Tutar :" + toplamTutar);
            Console.WriteLine("İndirim var mı " + indirimVarMi);
        }
        static void Main(string[] args)
        {
            MenuGoster();
            Console.WriteLine("-------------------");
            int secim = SecimAl();
            int adet = AdetAl();
            int fiyat = FiyatGetir(secim);
            int toplamTutar = SatırTutarıHesapla(adet, fiyat);
            double sonTutar = IndirimliTutarıHesapla(toplamTutar);
            bool indirimVarMi = IndirimHakkiVarMi(toplamTutar);
            Yazdır(secim, adet, fiyat, toplamTutar, indirimVarMi, sonTutar);

        }
    }
}
