namespace soru22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan alınan sayının kaç basamaklı olduğunu bulan programı yazınız. (örn. 3456 → 
        4 basamaklıdır.) */

            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int sayac = 0;
            while (true)
            {
                if (sayi > 0)
                {
                    sayi /= 10;
                    sayac++;
                }
                else
                    break;
            }
            Console.WriteLine($"{sayac} basamaklıdır.");
        }
    }
}
