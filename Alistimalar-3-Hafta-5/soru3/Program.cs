namespace soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Rastgele sayılarla oluşturulan 20 elemanlı bir dizinin çift olanlarının toplamının tek olanlarının 
        toplamına oranını bulunuz.*/

            int[] dizi = new int[20];
            Random rsgl = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rsgl.Next(0, 101);
                Console.Write(dizi[i] + " ");
            }
            Console.WriteLine();

            int cifttop = 0;
            int ciftsayac = 0;
            int tektop = 0;
            int teksayac = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    cifttop += dizi[i];
                    ciftsayac++;
                }
                else
                {
                    tektop += dizi[i];
                    teksayac++;
                }

            }
            if (cifttop > 0)
                Console.WriteLine("Çift sayıların ortalalaması:" + (cifttop / ciftsayac));
            if (tektop > 0)
                Console.WriteLine("Tek sayıların ortalaması:" + (tektop / teksayac));
        }
    }
}
