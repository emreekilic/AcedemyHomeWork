namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int number =Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            int kare= i*i;
            Console.WriteLine($"{i}^2 = {kare}");
        }
    }
}
