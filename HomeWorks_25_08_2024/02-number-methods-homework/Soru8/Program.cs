using System.Runtime.Intrinsics.Arm;

namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Logaritması hesaplanıcak sayıyı girin: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double sayi) && sayi > 0)
        {
            double log = Math.Log(sayi);
            Console.WriteLine($"Sayının doğal logaritması: {log}");
        }
        else 
        {
            Console.WriteLine("Gerçeli bir sayı giriniz!!");
        }

    }
}
