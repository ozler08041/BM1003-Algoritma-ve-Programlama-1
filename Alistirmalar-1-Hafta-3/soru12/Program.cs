namespace soru12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 3 sayı alıp en büyüğünü bulan programı yazınız (if-else kullanarak).

            Console.Write("1. sayıyı giriniz:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. sayıyı giriniz:");
            int s3 = Convert.ToInt32(Console.ReadLine());

            if (s1 >= s2 && s1 >= s3)
                Console.WriteLine(s1);
            else if (s2 >= s1 && s2 >= s3)
                Console.WriteLine(s2);
            else
                Console.WriteLine(s3);
        }
    }
}
