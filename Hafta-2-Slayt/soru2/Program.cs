namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen iki sayıdan küçük olanı ekrana bastıran kodu yazınız?

            Console.WriteLine("İlk sayıyı giriniz:");//Kullanıcıdan 2 sayı alalım.
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Hafta 3 şablon dosyasindaki if else ile...
            if (sayi1 > sayi2)
            {
                Console.WriteLine("Küçük sayı:" + sayi2);
            }
            else
            {
                Console.WriteLine("Küçük sayı:" + sayi1);
            }

            //Şu şekilde de yapılabilirdi...
            /*int kucuk_sayi = 0;
            if (sayi1 > sayi2)
                kucuk_sayi = sayi2;
            else
                kucuk_sayi = sayi1;
            Console.WriteLine("Küçük sayı:" + kucuk_sayi);*/
        }
    }
}
