namespace Soru16;

class Program
{
    static void Main(string[] args)
    {
       List<int>sayilar =new List<int>();
       int sayi;
       do
       {
        System.Console.Write("Bir sayı giriniz(çıkmak için 0 ): ");
        sayi=Convert.ToInt32(Console.ReadLine());
        if (sayi!=0)
        {
            sayilar.Add(sayi);
        }
       } while (sayi!=0);
       int toplam=0;
       foreach (int sayı in sayilar)
       {
        toplam+=sayı;
       }
       double ortalama =(double)toplam/sayilar.Count;
       System.Console.WriteLine("Girilen sayılar: ");
       foreach (int sayı in sayilar)
       {
        Console.Write(sayı+" ");
       }
       System.Console.WriteLine("\nOrtalam: "+ortalama);
    }
}    
