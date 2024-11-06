namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Taban sayıyı giriniz:");
        double taban = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üs sayıyı giriniz: ");
        double us = Convert.ToDouble(Console.ReadLine());

        double result = Math.Pow(taban, us);
        System.Console.WriteLine($"{taban} üzeri {us} = {result}");
    }
}
