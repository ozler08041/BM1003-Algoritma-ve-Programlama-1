namespace Alıştırmalar3_Hafta5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10 elemanı bir tam sayı dizisini kullanıcıdan alınan değerlerle dolduran ve dizideki elemanları 
        yazdıran kodu yazınız.*/

            int[] sayilar = new int[10];

            Console.Write("10 adet tam sayı giriniz:");

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(i + ". sayı:" + sayilar[i]);
            }
        }
    }
}
