namespace soru28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bir sayının mutlak değerini ve aynı zamanda işaretini (pozitif/negatif/sıfır) tek çıktıda 
        gösteriniz (örn. “|−12| = 12, Negatif”).*/

            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < 0)
            {
                Console.WriteLine($"|{sayi}| = {-1 * sayi}, Negatiftir.");
            }
            else if (sayi > 0)
            {
                Console.WriteLine($"|{sayi}| = {sayi}, Pozitiftir.");
            }
            else
                Console.WriteLine("Sayınız sıfırdır.");
        }
    }
}
