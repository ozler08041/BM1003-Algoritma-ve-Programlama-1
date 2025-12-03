namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10 elemanlı bir sayı dizisinin en büyük ve en küçük elemanlarını ve kaçıncı sırada olduklarını 
        bulan programı yazınız.*/

            int[] dizi = new int[10];
            Random rsgl = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rsgl.Next(0, 101);
            }
            int enk = dizi[0];
            int enb = dizi[0];
            int enksira = 0;
            int enbsira = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (enk > dizi[i])
                {
                    enk = dizi[i];
                    enksira = i;
                }
                if (enb < dizi[i])
                {
                    enb = dizi[i];
                    enbsira = i;
                }
            }

            Console.WriteLine(enksira + ". sayı en küçüktür ve sayı " + enk + "'tür.");
            Console.WriteLine(enbsira + ". sayı en büyüktür ve sayı " + enb + "'dir.");
        }
    }
}
