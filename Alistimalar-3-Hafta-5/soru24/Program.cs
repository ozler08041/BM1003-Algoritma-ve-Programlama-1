namespace soru24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fibonacci serisinin ilk 10 terimini ekrana yazdıran programı yazınız. (0, 1, 1, 2, 3, 5, 8, 13, 21, 
        34, 55, 89, 144, 233, 377, 610, 987.. diye devam eden her sayının kendisinden önceki iki 
        ardışık sayının toplamına eşit olduğu sayı dizisine Fibonacci dizisi denmektedir.)*/

            int n1 = 0, n2 = 1, n3;
            Console.Write(n1 + " " + n2 + " ");

            for (int i = 2; i < 10; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
