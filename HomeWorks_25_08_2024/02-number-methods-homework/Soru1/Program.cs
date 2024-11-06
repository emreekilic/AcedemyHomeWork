using System.Text.RegularExpressions;

namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        double number = Convert.ToDouble(Console.ReadLine());

        int result = (int)Math.Round(number);
        Console.WriteLine(result);
    }


}

