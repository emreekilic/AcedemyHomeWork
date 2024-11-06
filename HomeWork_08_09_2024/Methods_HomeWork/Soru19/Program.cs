namespace Soru19;

class Program
{
    static bool AsalMi(int sayi)
    {
        if (sayi<=1) return false;
        if (sayi<=2) return true;
        if (sayi%2==0) return false;
        for (int i = 5; i*i <=sayi; i+=6)
        {
            if (sayi%i==0||sayi%(i+2)==0)
            {
                return false;
            }
        }
        return true;
        
    }
    static void Main(string[] args)
    {
        Console.Write("Başlangıç değeri: ");
        int baslangic=int.Parse(Console.ReadLine());
        Console.Write("Bitiş değeri: ");
        int bitis = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Aralıktaki asal sayılar: ");
        for (int sayi = baslangic; sayi <= bitis; sayi++)
        {
            if (AsalMi(sayi))
            {
                System.Console.WriteLine(sayi);
            }
        }
        
    }
}
