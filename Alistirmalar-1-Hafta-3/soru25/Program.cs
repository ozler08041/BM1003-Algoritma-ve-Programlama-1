namespace soru25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan toplam dakika alınız; saat ve dakika cinsinden yazdırınız (örn. 135 → 2 saat 
        15 dakika).*/

            Console.Write("Dakikayı giriniz:");
            int dk = Convert.ToInt32(Console.ReadLine());
            int saat = 0;

            while (true)
            {
                if (dk >= 60)
                {
                    saat = dk / 60;
                    dk = dk % 60;
                }
                else
                    break;
            }
            Console.WriteLine($"{saat} saat {dk} dakika...");
        }
    }
}
