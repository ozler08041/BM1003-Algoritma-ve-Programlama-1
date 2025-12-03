namespace soru19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan bir sayı alınız. Sayı negatifse işaretini pozitife çevirerek mutlak değerini 
        ekrana yazdırınız.*/

            Console.Write("Bir tam sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int mutsayi = 0;
            if (sayi < 0)
            {
                mutsayi = sayi * (-1);
                Console.WriteLine(mutsayi);
            }
            else
                Console.WriteLine(sayi);
        }
    }
}
