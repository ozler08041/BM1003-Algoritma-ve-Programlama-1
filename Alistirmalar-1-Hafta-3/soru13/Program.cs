namespace soru13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan yıl bilgisini alıp, o yılın artık yıl olup olmadığını bulan programı yazınız.(Kural: 
        Yıl 4’e tam bölünüyorsa artık yıldır.)*/

            Console.Write("Yılı giriniz:");
            int yil = Convert.ToInt32(Console.ReadLine());

            if (yil % 4 == 0)
                Console.WriteLine(yil + " artık yıldır.");
            else
                Console.WriteLine(yil + " artık yıl değildir.");
        }
    }
}
