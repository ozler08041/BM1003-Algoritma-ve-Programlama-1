namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen cinsiyet ve yaş bilgilerine göre, kişinin askere gidip 
        gidemeyeceğini yazan C# kodu switch case kullanarak yazınız.*/

            Console.Write("Cinsiyetinizi giriniz(K ya da E):");
            char cins = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Yaşınızı giriniz:");
            int yas = Convert.ToInt32(Console.ReadLine());

            switch (cins)
            {
                case 'E':
                    if (yas > 20)
                        Console.WriteLine("Askere gidebilirsiniz.");
                    else
                        Console.WriteLine("Yaşınız tutmadığı için askere gidemezsiniz!");
                    break;
                case 'K':
                    Console.WriteLine("Kadın olduğunuzdan askere gidemezsiniz!");
                    break;
                default:
                    Console.WriteLine("Hatalı giriş!");
                    break;
            }
        }
    }
}
