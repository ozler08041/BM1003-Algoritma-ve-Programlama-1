namespace soru8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*100 elemanlı bir dizi tanımlayınız. Bu diziye 0 - 10 arasında rastgele sayılar atayın. Dizideki
            elemanların ortalamasını bulup, dizi elemanlarından kaç tanesinin elde edilen bu ortalama
            değerine eşit olduğunu hesaplayınız.*/

            int[] dizi = new int[100];
            Random rsgl = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rsgl.Next(0, 11);
                Console.Write(dizi[i] +" ");
            }
            Console.WriteLine();
            int toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                toplam += dizi[i];
            }
            int ortalama = toplam / dizi.Length;
            int esit = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == ortalama)
                    esit++;
            }
            Console.WriteLine($"Dizinin ortalaması: {ortalama}");
            Console.WriteLine($"Ortalama değere eşit olan eleman sayısı: {esit}");           
        }
    }
}
