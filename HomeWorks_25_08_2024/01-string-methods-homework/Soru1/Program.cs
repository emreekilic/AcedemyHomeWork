namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir cümle giriniz: ");
        string cumle = Console.ReadLine();

        int kelimeSayisi = cumle.Length;
        System.Console.WriteLine("Cümlede ki kelime sayısı :" + kelimeSayisi);
    }
}
