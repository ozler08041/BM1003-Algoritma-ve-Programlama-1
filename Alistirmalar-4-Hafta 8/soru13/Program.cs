namespace soru13
{
    internal class Program
    {
        //Yarıçapı parametre olarak alan bir dairenin alanını ve çevresini hesaplayan bir metot yazınız.
        static void alanCevreHesapla(int r)
        {
            int alan = 3 * r * r;
            int cevre = 2 * 3 * r;
            Console.WriteLine($"Çemberinizin alanı {alan} çevresi ise {cevre}'dir.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Yarıçapı giriniz:");
            int r =Convert.ToInt32(Console.ReadLine());
            alanCevreHesapla(r);
        }
    }
}
