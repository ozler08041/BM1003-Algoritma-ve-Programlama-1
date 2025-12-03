namespace soru31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Beden Kitle İndeksi (BMI): boy (m) ve kilo alın. BMI = kilo/(boy²). <18.5 → Zayıf, 18.5–24.9 → 
        Normal, 25–29.9 → Fazla Kilolu, ≥30 → Obez.*/

            Console.WriteLine("Boyunuzu m cinsinden giriniz:");
            double boy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kilonuzu kg cinsinde giriniz: ");
            int kg = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            double bki = kg / (boy * boy);
            Console.WriteLine(bki);
            if (bki < 18.5)
                Console.WriteLine("Zayıf");
            else if (bki > 18.5 && bki < 24.9)
                Console.WriteLine("Normal");
            else if (bki > 25 && bki < 29.9)
                Console.WriteLine("Fazla kilolu");
            else
                Console.WriteLine("Obez");
        }
    }
}
