namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i =1; i < number; i++)
        {
            int kup = i* i* i;
            System.Console.WriteLine($"{i}^3: {kup}");
        }
    }
}
