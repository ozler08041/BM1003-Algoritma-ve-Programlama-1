namespace soru7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen 3 basamaklı pozitif tam sayının yüzler basamağı, 
        onlar basamağı ve birler basamağını ayrıştıran programı yazınız. 
        Ekran çıktısı: 345 sayısının yüzler basamağı 3, onlar basamağı 4, birler 
        basamağı 5’tir.*/

            Console.Write("Üç basamaklı bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            //Öncelikle sayıyı doğru girilmiş mi diye komtrol edelim.
            if (sayi > 99 && sayi < 1000)
            {
                int birler = sayi % 10;//3 basamaklı sayının 10 ile bölümünden kalan her zaman birler basamağındaki sayıdır.
                int onlar = sayi % 100 / 10;//100 % onlar ve birler basamağını verir 10 ile de bölersek onlar basamağına ulaşılır.
                int yuzler = sayi / 100;//100 ile bölüm her zaman yüzler basamağını verir.
                Console.WriteLine(sayi + " sayısının yüzler basamağı " + yuzler + ", onlar basamağı " + onlar + ", birler basamağı " + birler + "'dir.");
            }
            else
                Console.WriteLine("Hatalı sayı girdiniz!");
        }
    }
}
