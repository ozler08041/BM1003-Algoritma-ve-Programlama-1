namespace soru10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen 10 adet sayıdan en büyüğünün kaçıncı sırada olduğunu yazan programı
            yazınız.*/
            int enb = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + ". sayıyı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > enb)
                    enb = sayi;
            }
            Console.WriteLine("En büyük sayınız:"+ enb);
        }
    }
}
