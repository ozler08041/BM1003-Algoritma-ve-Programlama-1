namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir sayının Armstrong sayısı olup olmadığını kontrol eden bir metot (fonksiyon) yazınız.
            Armstrong Sayısı:Bir sayının basamaklarındaki rakamların, basamak sayısı kadar üssü alınarak toplanması
            sonucunda elde edilen değer yine o sayıya eşitse bu sayı Armstrong sayısıdır.
            Örnek:
            · 153 = 13 + 53 + 33
            · 370 = 33 + 73 + 03*/
            static bool armstrongMu(int sayi)
            {
                int toplam = 0;
                int basamakSayisi = sayi.ToString().Length;
                int geciciSayi = sayi;
                while (geciciSayi > 0)
                {
                    int basamak = geciciSayi % 10;
                    toplam += (int)Math.Pow(basamak, basamakSayisi);
                    geciciSayi /= 10;
                }
                return toplam == sayi;
            }
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (armstrongMu(sayi))
                Console.WriteLine($"{sayi} Armstrong sayısıdır.");
            else
                Console.WriteLine($"{sayi} Armstrong sayısı değildir.");


        }
    }
}
