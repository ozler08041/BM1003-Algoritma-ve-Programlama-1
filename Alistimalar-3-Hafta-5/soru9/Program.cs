namespace soru9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen bir cümlede, girilen bir karakterden kaç tane olduğunu bulan programı yazınız. 

            Console.WriteLine("Bir cümle giriniz:");
            string cumle = Console.ReadLine();
            Console.WriteLine("Bir karakter giriniz:");
            char krkt = Convert.ToChar(Console.ReadLine());
            int sayac = 0;
           
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == krkt)
                    sayac++;
            }
            Console.WriteLine($"Girdiğiniz cümlede '{krkt}' karakteri {sayac} kere geçmektedir.");
        }
    }
}
