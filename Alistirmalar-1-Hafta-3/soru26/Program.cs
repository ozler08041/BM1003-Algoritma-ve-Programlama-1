namespace soru26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan sıcaklık türü (Santigrat için C, Fahrenheit için F) ve sıcaklık değeri alınız.
        Eğer tür C ise, girilen sıcaklığı Fahrenheit’a;
        eğer tür F ise, girilen sıcaklığı Santigrat’a dönüştürüp ekrana yazdırınız.
        Geçersiz tür girilirse “Hatalı seçim!” mesajı veriniz.*/

            Console.Write("Sıcaklığın değerini giriniz:");
            double sicak = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sıcaklığın türünü giriniz(C yada F):");
            char tur = Convert.ToChar(Console.ReadLine());

            if (tur == 'F')
            {
                sicak = (sicak - 32) * 5 / 9;
                Console.WriteLine($"Sıcaklık C cinsinde {sicak} derecedir.");
            }
            else if (tur == 'C')
            {
                sicak = (sicak * 5 / 9) + 32;
                Console.WriteLine($"Sıcaklık F cinsinde {sicak} derecedir.");
            }
            else
                Console.WriteLine("Hatalı seçim!");
        }
    }
}
