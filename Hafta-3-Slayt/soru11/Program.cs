namespace soru11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bir mağaza indirim kampanyası düzenlemektedir. Kullanıcıdan alınan ürün fiyatı ve kullanıcının üyelik durumuna (üye/üye değil) göre 
        aşağıdaki indirimleri uygulayın:
        Ürün fiyatı 100 TL'nin üzerindeyse ve kullanıcı üye değilse %5 indirim yapılacaktır.
        Ürün fiyatı 100 TL'nin üzerindeyse ve kullanıcı üye ise %10 indirim yapılacaktır.
        Ürün fiyatı 50 TL ile 100 TL arasında ise ve kullanıcı üye değilse hiç indirim yapılmayacaktır.
        Ürün fiyatı 50 TL ile 100 TL arasında ise ve kullanıcı üye ise %5 indirim yapılacaktır.*/

            Console.Write("Ürününüzün fiyatını giriniz:");
            int fiyat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üyelik durumunuzu giriniz:");
            string uye = Convert.ToString(Console.ReadLine());

            int indirim10 = fiyat - (fiyat / 10);
            int indirim5 = fiyat - (fiyat / 20);

            if (fiyat > 100)
            {
                if (uye == "üye")
                    Console.WriteLine("Ürününüzün indirimli fiyatı:" + indirim10);
                if (uye == "üye değil")
                    Console.WriteLine("Ürününüzün indirimli fiyatı:" + indirim5);
            }
            else if (50 <= fiyat && fiyat <= 100)
            {
                if (uye == "üye")
                    Console.WriteLine("Ürününüzün indirimli fiyatı:" + indirim5);
                if (uye == "üye değil")
                    Console.WriteLine("İndırimden yararlanamıyorsunuz! Ürününüzün fiyatı:" + fiyat);
            }
            else
                Console.WriteLine("Geçersiz fiyat girdiniz!");
            //Küsüratlı değerler için double da kullanılabilirdi.
        }
    }
}
