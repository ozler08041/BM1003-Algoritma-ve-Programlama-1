namespace soru8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen bir tam sayının tek mi veya çift mi olduğunu tespit 
        eden programı yazınız.  */

            Console.Write("Bir tam sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            //0 hariç olacağı için...
            if (sayi != 0)
            {
                if (sayi % 2 == 0)//2 ile bölümünden kalan 0'sa çifttir.
                    Console.WriteLine(sayi + " sayisi çifttir.");
                else
                    Console.WriteLine(sayi + " sayisi tektir.");
            }
            else
                Console.WriteLine("Girdiğiniz sayı sıfırdır!");
        }
    }
}
