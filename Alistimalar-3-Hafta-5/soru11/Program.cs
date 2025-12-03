namespace soru11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2x3 boyutunda bir matris oluşturup, dışarıdan değer girilen ve matrisi ekrana yazdıran bir 
            program yazınız.*/
            int[,] matris = new int[2, 3];
            Console.WriteLine("Matrisin elemanlarını giriniz:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Eleman [{i},{j}]: ");
                    matris[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matris:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
