namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir karakter giriniz: ");
        char karakter = Convert.ToChar(Console.ReadLine());

        karakter= char.ToLower(karakter);
        if(karakter=='a'|| karakter=='e'||karakter=='o'||karakter=='ö'||karakter=='ı'||karakter=='i'||karakter=='u'||karakter=='ü')
        {
            System.Console.WriteLine("Girilen harf sesli harftir.");
        }else
        {
            System.Console.WriteLine("Girilen harf sesli harf değildir.");
        }
    }
}
