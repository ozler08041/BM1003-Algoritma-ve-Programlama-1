namespace soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*0 ve 100 arasındaki rastgele sayılarla oluşturulan 20 elemanlı bir dizinin elemanlarının, 50’den 
        büyük olanların toplamının 50'den küçük olanların toplamına oranını hesaplayınız.*/

            int[] dizi = new int[20];
            Random rsgl = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rsgl.Next(0,101);
            }
            int kucuk = 0;
            int buyuk = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < 50)
                    kucuk += dizi[i];
                else//50 yi büyüklere sayalım...
                    buyuk += dizi[i];
            }
            double ort = ((double)buyuk + kucuk) / 2;
            Console.WriteLine($"Ortalama {ort}'dır.");
        }
    }
}
