namespace soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir dairenin yarıçapını girdi olarak alan, dairenin çevresini ve alanını 
        hesaplayan programı yazın.*/

            Console.Write("Çemberin yarıçapını giriniz:");
            int r = Convert.ToInt32(Console.ReadLine());
            //Alan formülü πr2 dir.π=3 olsun.
            int alan = 3 * r * r;
            //Çevre formülü 2πr dir.
            int cevre = 2 * 3 * r;

            Console.WriteLine("Çemberin çevresi:" + cevre);
            Console.WriteLine("Çemberin alanı:" + alan);
        }
    }
}
