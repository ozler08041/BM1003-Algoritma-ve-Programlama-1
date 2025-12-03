namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Rastgele sayılarla oluşturulan 20 elemanlı bir dizinin, elemanlarından kaç tanesinin dışarıdan 
        girilen bir sayıdan küçük olduğunu bulunuz.*/

            int[] dizi = new int[20];
            Random rsgl = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rsgl.Next(0, 101);
                Console.Write(dizi[i] + " ");

            }

            Console.WriteLine();
            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int ayni = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (sayi > dizi[i])
                    ayni++;
            }
            Console.WriteLine(ayni + " kadar eleman girdiğiniz sayıdan küçüktür.");
        }
    }
}
