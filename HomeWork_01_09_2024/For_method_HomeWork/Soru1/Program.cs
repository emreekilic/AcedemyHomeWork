namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("lütfen bir sayı giriniz: ");
        int number =Convert.ToInt32(Console.ReadLine());
        int toplam=0;
        for (int i = 0; i <=number; i++)
        {
            toplam += i;
        }
        System.Console.WriteLine($"{number}'a kadar olan sayıların tolamı: {toplam}");
    }
}
