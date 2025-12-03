namespace soru10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 3 sayıdan en büyüğünü bulan programı yazınız.

            Console.Write("1. sayıyı giriniz:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. sayıyı giriniz:");
            int s3 = Convert.ToInt32(Console.ReadLine());

            if (s1 >= s2 && s1 >= s3)//Büyük sayı s1 olur.
                Console.WriteLine("Büyük sayı:" + s1);
            else if (s2 >= s1 && s2 >= s3)//Büyük sayı s2 olur.
                Console.WriteLine("Büyük sayı:" + s2);
            else
                Console.WriteLine("Büyük sayı:" + s3);
        }
    }
}
