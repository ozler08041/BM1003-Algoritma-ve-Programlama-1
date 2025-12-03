namespace soru25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İlk 500 asal sayının toplamını hesaplayan programı yazınız.
            for (int i = 2; i <= 500; i++)
            {
                bool asal = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        asal = false;
                        break;
                    }
                }

                if (asal)
                    Console.Write(i + " ");
            }
        }
    }
}
