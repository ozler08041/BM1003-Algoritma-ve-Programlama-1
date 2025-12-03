namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1′den 100′e kadar olan tek sayıları ekrana yazan kodu yazınız. (for
        döngüsü)*/

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                    Console.Write(i + " ");
            }
        }
    }
}
