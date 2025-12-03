namespace soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10 boyutlu bir diziyi rastgele sayılarla doldurunuz. Bu sayıların ortalaması ile en büyük ve en 
        küçük sayının ortalamasını bularak, bu 2 ortalamanın farkını bulan programı yazınız.*/

            int[] dizi = new int[10];
            Random rsgl = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rsgl.Next(0, 101);
                Console.Write(dizi[i] + " ");
            }

            int toplam = 0;
            int enk = dizi[0];
            int enb = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                toplam += dizi[i];
                if (dizi[i] < enk)
                    enk = dizi[i];
                if (dizi[i] > enb)
                    enb = dizi[i];
            }

            double ortalama = (double)toplam / 10;
            double enortalama = ((double)enk + (double)enb) / 2;
            Console.WriteLine("Bu dizideki elemanların ortalaması:" + ortalama);
            Console.WriteLine("Bu dizideki küçük ve büyük sayının ortalaması:" + enortalama);
            Console.WriteLine("Bu iki ortalamanın farkı:" + (ortalama - enortalama));
        }
    }
    }
}
