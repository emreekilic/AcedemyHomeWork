namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
             System.Console.WriteLine("Bir sayı giriniz.");
            int sayi=Convert.ToInt32(Console.ReadLine());
            int result=sayi*sayi;
            if (sayi<0)
            {
                break;
            }
            System.Console.WriteLine($"sayısının karesi: {result} ");
        }
       
    }
}
