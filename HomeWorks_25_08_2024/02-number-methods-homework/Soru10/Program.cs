namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        string sayiİnput = Console.ReadLine();

        Console.Write("Basamak giriniz: ");
        string basamakİnput = Console.ReadLine();

        if(double.TryParse(sayiİnput, out double sayi) && (int.TryParse(basamakİnput, out int basamak) && basamak >= 0))
        {
            double yuvarlanmisSayi = Math.Round(sayi, basamak);
            System.Console.WriteLine($"Yuvarlanmış sayı: {yuvarlanmisSayi}");
        }
        else
        {
            System.Console.WriteLine("Geçerli sayı giriniz!!!");
        }
    }
}
