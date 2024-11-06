namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir metin giriniz :");
        string cumle = Console.ReadLine();

        string buyukHarf = cumle.ToUpper();
        string kucukHarf = cumle.ToLower();

        System.Console.WriteLine(buyukHarf + "\n" + kucukHarf);
    }
}
