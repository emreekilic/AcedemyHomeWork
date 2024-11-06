namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Başlangıç sayısını giriniz:");
        int sayi = int.Parse(Console.ReadLine());
        Console.Write("Üst sınırı giriniz: ");
        int ustSinir = int.Parse(Console.ReadLine());
        while (sayi <=ustSinir)
        {
            System.Console.WriteLine(sayi);
            sayi *=2;
        }
    }
}
