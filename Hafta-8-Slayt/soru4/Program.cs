namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İki sayının faktöriyellerinin toplamını bulunuz.
            static void faktorielHesapla(int sayi1,int sayi2)
            {
                if (sayi1 <0 || sayi2 <0)
                {
                    Console.WriteLine("Negatif sayıların faktöriyeli yoktur!");
                    return;
                }
                int faktoriel1 = 1;
                int faktoriel2 = 1;
                for (int i = 1; i <= sayi1; i++)
                {
                    faktoriel1 *= i;
                }
                for (int j = 1; j <= sayi2; j++)
                {
                    faktoriel2 *= j;
                }
                int toplam = faktoriel1 + faktoriel2;
                Console.WriteLine("İki sayının faktöriellerinin toplamı " + toplam +"'dır");
            }
            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            faktorielHesapla(sayi1, sayi2);
            //Kısa yol slayttaki! Ama değeri kullanıcıdan almamış?
            /*static int faktoriyelHesapla(int x)
            {
                int faktoriyel = 1;
                for (int i = 1; i <= x; i++)
                {
                    faktoriyel = faktoriyel * i;
                }
                return faktoriyel;
            }
            
            static void Main(string[] args)
            {
                Console.WriteLine(faktoriyelHesapla(5) + faktoriyelHesapla(6));
            }*/

}
}
}
