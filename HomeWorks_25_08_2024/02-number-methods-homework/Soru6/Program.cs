namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        double sin = Convert.ToDouble(Console.ReadLine());

        double result;
        result=Math.Sin(sin);
        System.Console.WriteLine(result);
    }
}
