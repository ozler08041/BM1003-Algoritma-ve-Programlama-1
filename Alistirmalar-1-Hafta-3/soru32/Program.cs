namespace soru32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ATM menüsü (switch-case):
        1- Para Yatır,
        2- Para Çek, 
        3- Bakiye, 
        4- Çıkış. Seçime göre uygun mesaj/işlem akışını yazdırınız (sadece menü ve mesaj; 
        gerçek bakiye takibi gerekmez).*/

            int bakiye = 1000;
            Console.WriteLine("İşlem türünü seçiniz:");
            string islem = Console.ReadLine();



            switch (islem)
            {
                case "Para Yatır":
                    Console.WriteLine("Miktar giriniz:");
                    int miktar = Convert.ToInt32(Console.ReadLine());
                    bakiye += miktar;
                    break;
                case "Para Çek":
                    Console.WriteLine("Miktar giriniz:");
                    int miktar2 = Convert.ToInt32(Console.ReadLine());
                    if ((bakiye - miktar2) < 0)
                        Console.WriteLine("Yetersiz bakiye!");
                    else
                        bakiye -= miktar2;
                    break;
                case "Bakiye":
                    Console.WriteLine(bakiye);
                    break;
                case "Çıkış":
                    Console.WriteLine("Bizi tercih ettiğiniz için teşekkürler.");
                    break;
                default:
                    Console.WriteLine("Hatalı giriş!");
                    break;
            }
        }
    }
}
