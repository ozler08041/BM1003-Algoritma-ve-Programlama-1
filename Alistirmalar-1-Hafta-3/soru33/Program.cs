namespace soru33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Taksi ücreti: Açılış 30 TL + km başı 12 TL. Eğer saat (0–23) 22–06 arasındaysa toplam 
        ücrete %20 gece zammı uygulayınız. Mesafe (km) ve saat alın, ücreti yazdırın.*/

            Console.Write("Saati giriniz:");
            int saat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Km yi giriniz:");
            int km = Convert.ToInt32(Console.ReadLine());
            int ucret = 30;

            if (saat > 0 && saat < 24)
            {
                if (saat > 22 || saat < 6)
                {
                    ucret = ((km * 12) / 5);
                    Console.WriteLine(ucret + (ucret * 12));
                }
                else
                {
                    ucret = km * 12;
                    Console.WriteLine(ucret);
                }
            }
            else
                Console.WriteLine("Hatalı giriş!");
        }
    }
}
