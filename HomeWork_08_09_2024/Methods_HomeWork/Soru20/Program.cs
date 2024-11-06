namespace Soru20;

class Program
{
    static string Birlestir(string[]dizi, string ayrac="")
    {
        return string.Join(ayrac,dizi);
    }
    static void Main(string[] args)
    {
        string[] kelimeler={"Merhaba","Dünya"};
        string birlesmisKelime=Birlestir(kelimeler,"-");
        Console.WriteLine(birlesmisKelime);
    }
}
