namespace soru18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            *3 dersten alınan notların ortalamasını bulan ve ortalama 50’nin altındaysa “Kaldı”, aksi
        halde “Geçti” yazan programı yazınız.*/

        Console.Write("1. notunuzu giriniz:");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. notunuzu giriniz:");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. notunuzu giriniz:");
            int not3 = Convert.ToInt32(Console.ReadLine());

            int ortalama = (not1 + not2 + not3) / 3;
            if (ortalama >= 50)
                Console.WriteLine("Geçti.");
            else
                Console.WriteLine("Kaldı.");
        }
    }
}
