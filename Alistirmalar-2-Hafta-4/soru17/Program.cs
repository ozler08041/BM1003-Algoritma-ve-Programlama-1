namespace soru17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İki basamaklı bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi >= 10 && sayi <= 99)
            {
                int birlerBasamagi = sayi % 10;
                int onlarBasamagi = sayi / 10;
                int tersSayi = birlerBasamagi * 10 + onlarBasamagi;
                if (tersSayi> sayi)
                {
                    Console.WriteLine("Ters çevrilmiş sayı orijinal sayıdan büyüktür.");
                }
                else if (tersSayi < sayi)
                {
                    Console.WriteLine("Ters çevrilmiş sayı orijinal sayıdan küçüktür.");
                }
                else
                {
                    Console.WriteLine("Ters çevrilmiş sayı orijinal sayıya eşittir.");
                }
            }
            else
            {
                Console.WriteLine("Lütfen iki basamaklı bir sayı giriniz!");
            }
        }
    }
}
