namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        double number = Convert.ToDouble(Console.ReadLine());

        double result = Math.Abs(number);
        Console.WriteLine("Sayının mutlak değeri: " + result);
    }
}
