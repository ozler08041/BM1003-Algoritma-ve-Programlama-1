namespace soru15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan alınan sayının 0 ile 100 arasında olup olmadığını kontrol eden programı 
        yazınız.*/

            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (0 < sayi && sayi < 100)
                Console.WriteLine("Sayınız 0-100 arasındadır.");
            else
                Console.WriteLine("Sayınız 0-100 arasında değildir.");
        }
    }
}
