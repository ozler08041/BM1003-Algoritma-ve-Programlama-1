namespace soru24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İki tamsayı a ve b (b ≠ 0) için bölüm ve kalanı hesaplayıp yazdırınız.//

            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            double bolum = sayi1 / sayi2;
            int kalan = sayi2 % sayi2;
            Console.WriteLine($"Bölüm {bolum}'dir kalan ise {kalan}'dır.");
        }
    }
}
