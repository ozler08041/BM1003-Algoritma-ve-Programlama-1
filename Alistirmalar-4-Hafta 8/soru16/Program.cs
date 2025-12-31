namespace soru16
{
    internal class Program
    {
        
        //s=x+y2 denklemin sonucunu hesaplayan bir metot yazınız. sonuç=x+y nin karesi olarak anladım...
        static void fonksiyon(int x, int y)
        {
            int sonuc = x + (y * y);
            Console.WriteLine("Sonuç:" + sonuc);
        }
        static void Main(string[] args)
        {
            Console.Write("Sayı giriniz:");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı giriniz:");
            int y=Convert.ToInt32(Console.ReadLine());
            fonksiyon(x, y);
        }
    }
}
