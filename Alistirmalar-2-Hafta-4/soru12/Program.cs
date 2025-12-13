namespace soru12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen bir tam sayının basamaklarındaki en büyük rakamı bulan programı yazınız.
            Console.WriteLine("Bir tam sayı giriniz:");
            int sayi=Convert.ToInt32(Console.ReadLine());
            int birler = sayi % 10;
            int onlar = sayi % 100/10;
            int yuzler = sayi % 1000/100;
            int binler = sayi % 10000/1000;
            int onbinler = sayi % 100000 / 10000;
            int enb = 0;
            while (true)
            {
                if (birler > enb)
                    enb = birler;
                else if (onlar > enb)
                    enb = onlar;
                else if (yuzler > enb)
                    enb = yuzler;
                else if (binler > enb)
                    enb = binler;
                else if (onbinler > enb)
                    enb = onbinler;
                else break;
            }
            Console.WriteLine("En büyük rakamı " + enb + "'dir.");
        }
    }
}
