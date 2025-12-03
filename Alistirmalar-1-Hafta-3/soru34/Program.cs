namespace soru34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan kargonun ağırlığını (kg) ve konum bilgisini (“şehir içi” veya “şehir dışı”) alınız.
        Kargo ücreti aşağıdaki kurallara göre hesaplanacaktır:
        0–1 kg arası → 30 TL
        1–5 kg arası → 50 TL
        5 kg üzeri → 50 TL + (ağırlık − 5) × 8 TL
        Eğer konum şehir dışı ise, hesaplanan tutarın üzerine %15 ekleyiniz. Ağırlık 0 veya negatif 
        girilirse “Geçersiz giriş!” mesajı veriniz.*/

            Console.Write("Ağırlık:");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Konum bilgisi:");
            string konum = Console.ReadLine();

            if (kg > 0)
            {
                switch (konum)
                {
                    case "şehir içi":
                        if (kg <= 1)
                            Console.WriteLine("30TL");
                        else if (kg > 1 && kg <= 5)
                            Console.WriteLine("50TL");
                        else
                            Console.WriteLine(50 + (kg - 5) * 8 + "TL");
                        break;
                    case "şehir dışı":
                        if (kg <= 1)
                            Console.WriteLine("34,5TL");
                        else if (kg > 1 && kg <= 5)
                            Console.WriteLine("57,5TL");
                        else
                            Console.WriteLine(3 * (50 + (kg - 5) * 8) / 20 + "TL");
                        break;
                }
            }
            else
                Console.WriteLine("Geçersiz giriş!");
        }
    }
}
