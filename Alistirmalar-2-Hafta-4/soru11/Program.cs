namespace soru11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*0 sayısı girilene kadar sayı girişini sağlayan ve bu sayıların kaç tane olduğunu, toplamını ve
            ortalamasını bulup sonucu ekrana yazdıran programı yazınız. */

            Console.WriteLine("Sayı giriniz:");
            int sayac = 0;
            int toplam = 0;
            while (true)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                    break;
                sayac++;
                toplam += sayi;
            }
            double ort = (double)toplam / sayac;
            Console.WriteLine($"{sayac} adet sayi girdiniz.Bu sayıların toplamı {toplam} ortalaması da {ort}'dur.");
        }
    }
}
