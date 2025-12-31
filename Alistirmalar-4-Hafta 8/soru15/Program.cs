namespace soru15
{
    internal class Program
    {
        /*Bir dikdörtgenin 2 kenarını parametre olarak alan ve bu dikdörtgenin alanını ve çevresini
        hesaplayan programı yazınız.*/
        static void alanCevreHesapla(int knr1,int knr2)
        {
            int  alan = knr1*knr2;
            int cevre= (2*knr1)+(2*knr2);
            Console.WriteLine($"Dikdörtgenin alanı {alan} çevresi ise {cevre}'dir.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dikdörtgenin 1. kenarını giriniz:");
            int knr1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin 2. kenarını giriniz:");
            int knr2=Convert.ToInt32(Console.ReadLine());
            alanCevreHesapla(knr1, knr2);
        }
    }
}
