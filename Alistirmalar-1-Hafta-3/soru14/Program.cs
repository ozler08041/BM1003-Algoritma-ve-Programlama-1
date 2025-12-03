namespace soru14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir sayı alınız, bu sayının karesini ve küpünü hesaplayıp ekrana yazdırınız.

            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int kare = sayi * sayi;
            int kup = sayi * sayi * sayi;

            Console.WriteLine("Karesi:" + kare);
            Console.WriteLine("Küpü:" + kup);
        }
    }
}
