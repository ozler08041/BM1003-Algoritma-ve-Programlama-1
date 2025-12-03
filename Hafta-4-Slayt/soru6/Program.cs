namespace soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1′den 100′e kadar olan tek sayıları ekrana yazan kodu yazınız. (while
        döngüsü)*/

            int sayi = 1;
            while (sayi <= 100)
            {
                if (sayi % 2 == 1)
                    Console.Write(sayi + " ");
                sayi++;
            }
        }
    }
}
