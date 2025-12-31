namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği 2 sayının karelerinin toplamını hesaplayıp geri döndüren bir metot yazınız. 
            
            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            kareTopla(sayi1, sayi2);
            Console.WriteLine("Sonuç:"+ kareTopla(sayi1,sayi2));

        }
        static int kareTopla(int sayi1, int sayi2)
        {
            return (sayi1 * sayi1) + (sayi2 * sayi2);
        }
    }
}
