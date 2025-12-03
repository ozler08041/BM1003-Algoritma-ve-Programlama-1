namespace Alıştırmalar1_Hafta3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 3 sayıyı küçükten büyüğe doğru ekrana yazan programı yazınız.

            Console.Write("1. sayıyı giriniz:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. sayıyı giriniz:");
            int s3 = Convert.ToInt32(Console.ReadLine());

            if (s1 < s2 && s1 < s3)
            {
                if (s2 < s3)
                    Console.WriteLine(s1 + "<" + s2 + "<" + s3);
                else
                    Console.WriteLine(s1 + "<" + s3 + "<" + s2);
            }
            else if (s2 < s1 && s2 < s3)
            {
                if (s1 < s3)
                    Console.WriteLine(s2 + "<" + s1 + "<" + s3);
                else
                    Console.WriteLine(s2 + "<" + s3 + "<" + s1);
            }
            else if (s3 < s1 && s3 < s2)
            {
                if (s1 < s2)
                    Console.WriteLine(s3 + "<" + s1 + "<" + s2);
                else
                    Console.WriteLine(s3 + "<" + s2 + "<" + s1);
            }
            else
                Console.WriteLine("Bütün sayılar eşittir.");
        }
    }
}
