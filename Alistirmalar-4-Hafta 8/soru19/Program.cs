namespace soru19
{
    internal class Program
    {
        /*Bir sayı dizisini parametre olarak alan ve en büyük elemanı bulup geri döndüren metodu
        yazınız.*/
        static void enBuyukBul(int[] dizi)
        {
            int enb = dizi[0];
            for ( int i = 1;i<dizi.Length;i++)
            {
                if(dizi[i] > enb)
                    enb=dizi[i];
                
            }
            Console.WriteLine(enb);
        }
        static void Main(string[] args)
        {
            int[] dizi= {1,2,3,4,5,6,7,8,9,10};
            enBuyukBul (dizi);
        }
    }
}
