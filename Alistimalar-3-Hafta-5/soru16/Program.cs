namespace soru16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1 = { 1, 5, 6, 9, 3, 3 };
            int[] dizi2 = { 1, 5, 5, 5, 10, 17 };
            int[] dizi3 = { 1, 3, 3, 5, 5, 5};
            int ucler1 = 0;
            int ucler2 = 0;
            int ucler3 = 0;
            int besler1 = 0;
            int besler2 = 0;
            int besler3 = 0;
            for (int i = 0; i < dizi1.Length; i++)
            {
                if (dizi1[i] == 3)
                {
                    ucler1++;
                }
                if (dizi1[i] == 5)
                {
                    besler1++;
                }
            }
            for (int i = 0; i < dizi2.Length; i++)
            {
                if (dizi2[i] == 3)
                {
                    ucler2++;
                }
                if (dizi2[i] == 5)
                {
                    besler2++;
                }
            }
            for (int i = 0; i < dizi3.Length; i++)
            {
                if (dizi3[i] == 3)
                {
                    ucler3++;
                }
                if (dizi3[i] == 5)
                {
                    besler3++;
                }
            }
            if (ucler1 > besler1)
            {
                Console.WriteLine("Doğru");
            }
            else 
            {
                Console.WriteLine("Yanlış");
            }
            if (ucler2 > besler2)
            {
                Console.WriteLine("Doğru");
            }
            else
            {
                Console.WriteLine("Yanlış");
            }
            if (ucler3 > besler3)
            {
                Console.WriteLine("Doğru");
            }
            else
            {
                Console.WriteLine("Yanlış");
            }
        }
    }
}
