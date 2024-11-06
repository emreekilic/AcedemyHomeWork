namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Lütfen bir açı değeri (derece) giriniz:");
            double derece = Convert.ToDouble(Console.ReadLine());

           
            const double pi = Math.PI;
            double radyan = derece * (pi / 180);

            Console.WriteLine($"{derece} derece, {radyan:F2} radyana eşittir.");

    }

}