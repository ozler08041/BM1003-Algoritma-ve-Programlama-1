namespace soru12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 boyutlu bir diziyi tek boyutlu bir diziye çeviren programı yazınız.
            int[,] boyut2 = new int[3, 3];
            Random rsgl = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boyut2[i, j] = rsgl.Next(1, 11);
                }
            }
            Console.WriteLine("2 boyutlu dizi:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(boyut2[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[] boyut1 ={ boyut2[0,0], boyut2[0,1], boyut2[0,2], boyut2[1,0],
                boyut2[1,1], boyut2[1,2], boyut2[2,0], boyut2[2,1], boyut2[2,2]};

            Console.WriteLine("1 boyutlu dizi:");
            for (int i = 0;i< boyut1.Length; i++)
            {
                Console.Write(boyut1[i] + " ");
            }
        }
    }
}
