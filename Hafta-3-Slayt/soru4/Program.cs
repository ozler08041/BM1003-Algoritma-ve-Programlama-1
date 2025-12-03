namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcı adının doğru GİRİLİP GİRİLMEDİĞİNİ gösteren bir program 
        yazınız..:*/
            //Kullanıcı adımız "Havva" olsun.

            Console.Write("Kullanıcı adınızı giriniz:");
            string kulad = Convert.ToString(Console.ReadLine());
            // Doğruluk kontrolü için bool kullanmalıyız.
            bool dogru_kulad = kulad == "Havva";
            Console.WriteLine("Girdiğiniz kullanıcı adı " + dogru_kulad);
        }
    }
}
