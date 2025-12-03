namespace soru17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 5, 3, 5, 7, 5, 9, 11 };
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == 5)
                {
                    dizi[i] = 0;
                }
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] != 0)
                {
                    Console.Write(dizi[i] + " ");
                }
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == 0)
                {
                    Console.Write(dizi[i] + " ");
                }
            }
        }
    }
}
