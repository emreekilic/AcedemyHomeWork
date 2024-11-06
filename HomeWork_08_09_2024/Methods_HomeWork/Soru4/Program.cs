using Microsoft.CSharp.RuntimeBinder;

namespace Soru4;

class Program
{
    static double Result(double vizeNotu,double finalNotu)
    {
        const double gecmeNotu=50;
        double ortalama= (vizeNotu* 0.4)+ (finalNotu * 0.6);
        if (ortalama>= gecmeNotu)
        {
            System.Console.WriteLine("Geçti");
        }
        else
        {
            System.Console.WriteLine("Kaldı");
        }
        return ortalama;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Result(90,23));
    }
}
