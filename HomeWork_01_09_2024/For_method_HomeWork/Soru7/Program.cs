namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz:");
        int number =Convert.ToInt32(Console.ReadLine());
        int toplam=0;
        for (int i = 2; i <=number; i+=2)
        {
            toplam+=i;
        }
        System.Console.WriteLine($"{number}'ye kadar olan çift sayıların toplamı: {toplam}");
    }
}
