namespace soru19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10 ile 1000 arasındaki tam kare sayıları ekrana yazdıran programı yazınız. (Tam kare, karekökü 
            bir doğal sayı olan tam sayılara denir. 0, 1, 4, 9, 16, 25, 36, 49... tam kare sayılara örnektir.) */
            for (int i =0; i<= 100; i++)
            {
                if (i*i <= 1000)
                    Console.Write(i*i + ", ");
            }
        }
    }
}
