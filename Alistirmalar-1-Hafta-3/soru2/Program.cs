namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen 3 basamaklı pozitif bir tam sayının basamakları toplamını bulan 
        programı yazınız. Ör: 123 sayısının basamakları toplam 1+2+3 = 6’dır.*/

            Console.Write("Üç basamaklı bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (99 < sayi && sayi < 1000)
            {
                int birler = sayi % 10;
                int onlar = sayi % 100 / 10;
                int yuzler = sayi / 100;
                int toplam = yuzler + onlar + birler;
                Console.WriteLine(sayi + " sayısının basamaklarının toplamı " + yuzler + "+" + onlar + "+" + birler + " = " + toplam + "'dır.");

            }
        }
    }
}
