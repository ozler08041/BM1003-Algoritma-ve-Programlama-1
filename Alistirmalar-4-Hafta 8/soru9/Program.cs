using System.Diagnostics.Metrics;

namespace soru9
{
    internal class Program
    {
        static int BasamakSayisiHesapla(int sayi)
        {
            if (sayi < 0)
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
            }
            if (sayi == 0)
            {
                return 1;
            }
            int basamakSayisi = 0;
            while (sayi > 0)
            {
                sayi /= 10;
                basamakSayisi++;
            }
            return basamakSayisi;
        }

        static void Main(string[] args)
        {
            /*Pozitif bir sayıyı parametre olarak alan ve bu sayının kaç basamaklı olduğunu hesaplayıp geri
            döndüren bir metot tanımlayınız. */
            Console.WriteLine("Pozitif bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int basamakSayisi = BasamakSayisiHesapla(sayi);
            Console.WriteLine($"Girdiğiniz sayi {basamakSayisi} basamaklıdır.");
        }
    }
}
