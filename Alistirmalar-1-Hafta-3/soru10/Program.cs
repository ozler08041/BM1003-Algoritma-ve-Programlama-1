namespace soru10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan bir sayının 5’e bölünüp bölünmediğini bulan programı yazınız.

            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 5 == 0)
                Console.WriteLine("Sayınız 5'e bölünebilir.");
            else
                Console.WriteLine("Sayınız 5'e bölünemez.");
        }
    }
}
