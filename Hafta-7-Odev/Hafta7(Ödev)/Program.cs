namespace Hafta7_Ödev_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[4];
            Console.Write("Kanguruların konumlarını ve ziplama uzunluklarını giriniz:");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(" ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Clear();
            Console.WriteLine($"Girdi:{dizi[0]} {dizi[1]} {dizi[2]} {dizi[3]}");

            int x1 = dizi[0];
            int x2 = dizi[1];
            int V1 = dizi[2];
            int V2 = dizi[3];
            int bulnok = 0;

            for (int i = 1; i < 10000; i++)
            {
                x1 += V1;
                x2 += V2;

                if (x1 == x2)
                {
                    bulnok = i;
                    break;
                }
            }
            if (x1 == x2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"{bulnok}. zıplamada buluşurlar ve konumları {x1}'dir.");
            }
            else
                Console.WriteLine("No");
        }
    }
}
