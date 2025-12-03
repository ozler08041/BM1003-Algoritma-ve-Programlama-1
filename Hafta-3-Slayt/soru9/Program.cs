namespace soru9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen bir tam sayının pozitif negatif veya sıfır olduğunu 
        tespit eden programı yazınız. */

            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)
                Console.WriteLine("Sayınız pozitiftir.");
            else if (sayi < 0)
                Console.WriteLine("Sayınız negatiftir.");
            else
                Console.WriteLine("Sayınız sıfırdır.");
        }
    }
}
