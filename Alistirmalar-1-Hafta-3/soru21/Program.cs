namespace soru21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan AA, BB, CC, FF gibi bir not alınsın. Buna göre ekrana açıklama yazdırınız.
        "AA → Çok İyi"
        "BB → İyi"
        "CC → Orta"
        "FF → Başarısız"*/

            Console.Write("Not bilginizi giriniz:");
            string not = Console.ReadLine();

            switch (not)
            {
                case "AA":
                    Console.WriteLine("Çok iyi");
                    break;
                case "BB":
                    Console.WriteLine("İyi");
                    break;
                case "CC":
                    Console.WriteLine("Orta");
                    break;
                case "FF":
                    Console.WriteLine("Başarısız");
                    break;
                default:
                    Console.WriteLine("Geçersiz not bilgisi!");
                    break;
            }
        }
    }
}
