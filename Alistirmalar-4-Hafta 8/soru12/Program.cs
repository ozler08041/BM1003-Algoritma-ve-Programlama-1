using System.Reflection.Metadata;

namespace soru12
{
    internal class Program
    {
        static void onlukCevir(int ikiliSayi)
        {
            int onlukSayi = 0;
            int basamak = 0;
            while (ikiliSayi > 0)
            {
                int rakam = ikiliSayi % 10;
                onlukSayi += rakam * (int)Math.Pow(2, basamak);
                ikiliSayi /= 10;
                basamak++;
            }
            Console.WriteLine($"Onluk (decimal) sayı: {onlukSayi}");
        }
        static void Main(string[] args)
        {
            /*Parametre olarak ikili bir sayıyı alan ve bu sayıyı onluk tabana dönüştüren bir metot yazınız.
            Örnek: 
            101-> 5*/
            Console.Write("İkili (binary) bir sayı giriniz: ");
            int ikiliSayi = Convert.ToInt32(Console.ReadLine());
            onlukCevir(ikiliSayi);
        }
    }
}
