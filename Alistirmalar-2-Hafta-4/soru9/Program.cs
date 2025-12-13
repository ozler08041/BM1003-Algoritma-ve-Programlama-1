namespace soru9
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*Klavyeden sıfır girinceye kadar sayı girilmesini sağlayan negatif ve pozitifleri ayrı ayrı toplayıp
ekrana yazdıran programı yazınız.*/
            Console.WriteLine("Bir sayı giriniz:");
            int negatiftoplam = 0;
            int pozitiftoplam = 0;
            while (true)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                {
                    break;
                }
                else if (sayi < 0)
                {
                    negatiftoplam += sayi;

                }
                else
                {
                    pozitiftoplam += sayi;

                }
            }
            Console.WriteLine("Negatif sayıların toplamı: " + negatiftoplam);
            Console.WriteLine("Pozitif sayıların toplamı: " + pozitiftoplam);
        }
    }
}
