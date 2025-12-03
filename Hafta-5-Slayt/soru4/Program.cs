namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*continue değimi kullanarak 0-100 arasındaki çift sayıların
        ekrana yazdırınız.*/

            for (int i = 1; i < 100; i++)
                if (i % 2 == 1)
                    continue;
                else
                    Console.WriteLine(i);
        }
    }
}
