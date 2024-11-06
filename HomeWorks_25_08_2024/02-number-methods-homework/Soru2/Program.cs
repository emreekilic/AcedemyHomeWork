namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı giriniz: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        if (number1 > number2)
        {
            Console.WriteLine($"Birinci sayı{number1} büyüktür {number2}");
        }
        else if (number2 > number1)
        {
            Console.WriteLine($"İkinci sayı {number2} büyüktür {number1}");
        }
        else
        {
            Console.WriteLine("Sayılar eşittir.");
        }

    }
}
