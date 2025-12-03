namespace soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden yaş ve cinsiyet bilgilerini alınız ve 20 yaşından büyükse ve erkekse askere gidebilir yoksa gidemez bilgisi veren kodu yazınız.

            Console.WriteLine("Yaşınızı giriniz:");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cinsiyetinizi giriniz:");
            string cins = Convert.ToString(Console.ReadLine());
            //Hafta 3 şablondaki bilgiler ile...

            if (yas > 20)
            {
                if (cins == "erkek")
                    Console.WriteLine("Askere gidebilir.");
                else
                    Console.WriteLine("Kız olduğu için askere gidemez!");
            }
            else if (yas < 20)
            {
                if (cins == "erkek")
                    Console.WriteLine("Yaşından dolayı askere gidemez.");
                else
                    Console.WriteLine("Hem yaşından hem de kız olduğu için gidemez.");
            }
            else
                Console.WriteLine("Geçersiz bilgiler!");
        }
    }
}
