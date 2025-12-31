namespace soru4
{
    internal class Program
    {
        static void fonk(int x, int y, int z)
        {
            int sonuc = (x + y) * z;
            Console.WriteLine(sonuc);
        }
        static void Main(string[] args)
        {
            //Parametre olarak üç sayı (x,y,z) alan ve (x+y).z çıktısını geri döndüren bir metodu yazınız.
            
            Console.Write("1. sayı:");
            int x = Convert.ToInt32 (Console.ReadLine());
            Console.Write("2. sayı:");
            int y = Convert.ToInt32 (Console.ReadLine());
            Console.Write("3. sayi:");
            int z = Convert.ToInt32 (Console.ReadLine());
            fonk (x, y, z);
        }
    }
}
