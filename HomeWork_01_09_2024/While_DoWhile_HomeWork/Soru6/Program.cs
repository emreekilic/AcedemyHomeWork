namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("bir sayı giriniz: ");
        string metin =Console.ReadLine();

        int index = metin.Length -1;
        while (index >= 0)
        {
            Console.Write(metin[index]);
            index--;
        }
    }
}
