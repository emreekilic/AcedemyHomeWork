namespace Soru6;

class Program
{
    static int Numbers(int sayi)
    {

        if (sayi % 2 != 0)
        {
            System.Console.WriteLine("Sayı Tektir");
        }
        else
        {
            System.Console.WriteLine("Sayı Çifttir");
        }
        return sayi;

    }
    static void Main(string[] args)
    {
        Console.WriteLine(Numbers(6));
    }
}
