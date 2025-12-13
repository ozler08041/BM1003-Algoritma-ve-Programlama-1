using Microsoft.VisualBasic;

namespace Hafta8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir sayının mükemmel sayı olup olmadığını kontrol eden bir metot (fonksiyon) yazınız.
            Mükemmel sayı: Kendisi hariç pozitif tam bölenlerinin toplamı kendisine eşit olan sayılardır.
            Örneğin: 6 = 1 + 2 + 3, 28 = 1 + 2 + 4 + 7 + 14*/
            static bool mukemmelMi(int sayi)
            {
                if (sayi < 1)
                    return false;
                int toplam = 0;
                for (int i = 1; i <= sayi / 2; i++)
                {
                    if (sayi % i == 0)
                        toplam += i;
                }
                return toplam == sayi;

            }
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (mukemmelMi(sayi))
                Console.WriteLine($"{sayi} mükemmel sayıdır.");
            else
                Console.WriteLine($"{sayi} mükemmel sayı değildir.");
        }
    }
}
