namespace soru20
{
    internal class Program
    {
        /* 2x2 boyutunda bir matrisi parametre olarak alan ve transpozunu alıp sonucu geriye döndüren 
        bir metot yazınız.*/
        static void transpozAl(int[,] matris)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    
                    Console.Write(matris[j,i] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] matris = new int[2, 2];
            Random rsgl = new Random();
            for (int i = 0; i < 2;i++)
            {
                for (int j = 0; j < 2;j++)
                {
                    matris[i,j] = rsgl.Next(1,11);
                    Console.Write(matris[i,j]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------");
            transpozAl(matris);
        }
    }
}
