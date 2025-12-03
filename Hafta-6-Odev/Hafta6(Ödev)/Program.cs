namespace Hafta6_Ödev_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N giriniz:");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] matris = new int[N, N];
            Random rnd = new Random();

            Console.WriteLine("\nOluşturulan Matris:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matris[i, j] = rnd.Next(-9, 10);
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();//Alt satıra geçmek için!
            }

            int anaToplam = 0;
            int yardimcicarpim = 1;//Çarpma olduğu için 1 demeliyiz.
            int negatifSayac = 0;
            int[] elemanlar = new int[N * N];
            int index = 0;

            for (int i = 0; i < N; i++)
            {
                anaToplam += matris[i, i];
                yardimcicarpim *= matris[i, N - 1 - i];
                for (int j = 0; j < N; j++)
                {
                    elemanlar[index] = matris[i, j];
                    if (matris[i, j] < 0)
                    {
                        negatifSayac += 1;
                    }
                    index += 1;
                }
            }

            int en = elemanlar[0];
            int enTekrar = 0;

            for (int i = 0; i < elemanlar.Length; i++)
            {
                int sayac = 0;
                for (int j = 0; j < elemanlar.Length; j++)
                {
                    if (elemanlar[i] == elemanlar[j])
                    {
                        sayac = sayac + 1;
                    }
                }
                if (sayac > enTekrar || (sayac == enTekrar && elemanlar[i] < en))
                {
                    enTekrar = sayac;
                    en = elemanlar[i];
                }
            }

            int asalToplam = 0;
            int asalAdet = 0;
            for (int i = 0; i < elemanlar.Length; i++)
            {
                int sayi = elemanlar[i];
                int asalMi = 1;

                if (sayi < 2)
                {
                    asalMi = 0;
                }
                else
                {
                    int k = 2;
                    while (k <= Math.Sqrt(sayi))//mutlak değerini öğrenmiştik...
                    {
                        if (sayi % k == 0)
                        {
                            asalMi = 0;
                        }
                        k = k + 1;
                    }
                }

                if (asalMi == 1)
                {
                    asalToplam = asalToplam + sayi;
                    asalAdet = asalAdet + 1;
                }
            }

            Console.WriteLine("Ana köşegen toplamı:" + anaToplam);
            Console.WriteLine("Yardımcı köşegen çarpımı:" + yardimcicarpim);
            Console.WriteLine("Negatif sayı adedi:" + negatifSayac);
            Console.WriteLine("En sık tekrar eden sayı:" + en);

            if (asalAdet > 0)
            {
                double ort = (double)asalToplam / asalAdet;
                Console.WriteLine("Asal sayıların ortalaması:" + ort.ToString("0.0"));
            }
            else
            {
                Console.WriteLine("Asal sayı yok.");
            }

            int[,] donmus = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    donmus[j, N - 1 - i] = matris[i, j];
                }
            }

            Console.WriteLine("Saat yönünde 90 derece döndürülmüş matris:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(donmus[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
