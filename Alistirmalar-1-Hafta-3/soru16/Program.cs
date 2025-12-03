namespace soru16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan alınan sayının hem pozitif hem de çift olup olmadığını bulan programı 
        yazınız.*/

            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0 && sayi % 2 == 0)
                Console.WriteLine("Sayınız hem pozitif hem de çifttir.");
            else
                Console.WriteLine("Sayınız hem pozifit hem de çift değildir!");
        }
    }
}
