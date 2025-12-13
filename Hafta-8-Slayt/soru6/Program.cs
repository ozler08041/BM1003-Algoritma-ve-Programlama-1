using System.Runtime.ConstrainedExecution;

namespace soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*İki ayrı diziyi tek bir dizi hâline getiren bir metot yazınız.
            Metot, kendisine parametre olarak verilen iki dizinin elemanlarını
            sırasıyla yeni bir dizi içine eklemeli ve bu yeni diziyi geri döndürmelidir.
            Birleştirme işlemi sırasında dizilerin boyutları dikkate alınmalı ve her
            iki dizinin tüm elemanları eksiksiz şekilde yeni dizi içinde yer almalıdır.*/
            static int[] diziBirles(int[]dizi1, int[] dizi2)
            {
                int[] yeniDizi = new int[dizi1.Length + dizi2.Length];
                for (int i = 0; i < dizi1.Length; i++)
                {
                    yeniDizi[i] = dizi1[i];
                }
                for (int j = 0; j < dizi2.Length; j++)
                {
                    yeniDizi[dizi1.Length + j] = dizi2[j];
                }
                return yeniDizi;
            }
            int[] dizi1 = { 1, 2, 3, 4, 5 };
            int[] dizi2 = { 6, 7, 8, 9};
            int[] birlesik = diziBirles(dizi1, dizi2);
            for (int i = 0; i < birlesik.Length; i++)
            {
                Console.Write(birlesik[i] + " ");
            }
        }
    }
}
