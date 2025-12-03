namespace soru23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bir çalışanın saatlik ücreti 200 TL. Kullanıcının girdiği çalışma saatine göre maaşı 
        hesaplayınız. Eğer çalışma saati 40’tan fazlaysa fazla çalışılan her saat için %50 zamlı 
        ödeme yapılacaktır.*/

            Console.Write("Çalışma saatinizi giriniz:");
            int saat = Convert.ToInt32(Console.ReadLine());
            int maas = 0;

            if (saat <= 40 && saat > 0)
            {
                maas = saat * 200;
                Console.WriteLine($"Maaşınız {maas}TL dir.");
            }
            else if (saat > 40)
            {
                maas = (40 * 200) + (saat - 40) * 300;
                Console.WriteLine($"Maaşınız {maas}TL dir.");
            }
            else
                Console.WriteLine("Geçersiz saat!");
        }
    }
}
