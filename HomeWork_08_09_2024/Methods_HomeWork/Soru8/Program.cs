namespace Soru8;

class Program
{
    static double Derece(double santigrat)
    {
        return (santigrat * 9 / 5)+32;
    }
    static void Main(string[] args)
    {
        Console.Write("Santigrat Sıcaklığını giriniz: ");
        double santigrat=Convert.ToDouble(Console.ReadLine());

        double fahrenheit =Derece(santigrat);
        System.Console.WriteLine(Derece(santigrat));
    }
}
