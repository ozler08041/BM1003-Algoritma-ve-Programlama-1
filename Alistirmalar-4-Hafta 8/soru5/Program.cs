namespace soru5
{
    internal class Program
    {
        //Santigrat dereceyi Fahrenheit'e çeviren bir metot yazınız. 

        static void fahrenheitDegis(int C)
        {
            double F = (C * 1.8) + 32;
            Console.WriteLine($"Fahrenheit cinsinde {F} derecedir.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sıcaklığı santigrat cinsinde giriniz:");
            int C = Convert.ToInt32(Console.ReadLine());
            fahrenheitDegis(C);

        }
    }
}
