using System.Reflection.Metadata;

namespace soru18
{
    internal class Program
    {
        /*Parametre olarak bir dizi alan ve bu dizideki negatif sayılar ile pozitif sayıların sayısını ekrana
        yazdıran bir metot yazınız.*/
        static void negatifPozitifAdet(int[] dizi)
        {
            int negatifsayac = 0;
            int pozitifsayac = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < 0)
                    negatifsayac++;
                else
                    pozitifsayac++;

            }
            Console.WriteLine($"Pozitif adedi {pozitifsayac} (0'da dahil) negatif adedi ise {negatifsayac}'dır.");
        }
            static void Main(string[] args)
        {
            int[] dizi = new int[10];
            Random rsgl= new Random();
            for(int i = 0;  i < dizi.Length; i++)
            {
                dizi[i]=rsgl.Next(-10,11);
                Console.Write(dizi[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            negatifPozitifAdet(dizi);

        }
    }
}
