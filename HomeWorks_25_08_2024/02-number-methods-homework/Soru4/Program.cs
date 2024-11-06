namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        double number = Convert.ToDouble(Console.ReadLine());

        double result = Math.Sqrt(number);
        System.Console.WriteLine(result);
    }
}
