namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayısı giriniz: ");
        string input1 = Console.ReadLine();

        System.Console.Write("İkinci sayıyı giriniz: ");
        string input2 = Console.ReadLine();

        if(double.TryParse(input1, out double sayı1) && (double.TryParse(input2, out double sayı2)))
        {
            double kucukSayi = sayı1 < sayı2 ? sayı1 : sayı2;
            System.Console.WriteLine($"Girdiğiniz küçük sayı: {kucukSayi}");
        }
        else 
        {
            System.Console.WriteLine("Geçerli sayı giriniz!!");
        }
    }
}
