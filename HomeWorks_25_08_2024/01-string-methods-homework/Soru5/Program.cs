namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ana metni giriniz: ");
        string anaMetin = Console.ReadLine();

        Console.Write("Aranan metni girin: ");
        string araMetin = Console.ReadLine();

        int index = anaMetin.IndexOf(araMetin);
        if(index != -1)
        {
            System.Console.WriteLine($"Aranan metin, ana metnin {index} indexsinde.");
        }
        else
        {
            Console.WriteLine("Aranan metin bulunamaıştır.");
        }

        
    }
}
