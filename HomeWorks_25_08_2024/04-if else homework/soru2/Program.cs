namespace soru2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Üç sayı giriniz: ");
        
        Console.Write("1.sayıyı giriniz: ");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.Write("2. sayıyı giriniz: ");
        int sayi2 = int.Parse(Console.ReadLine());

        Console.Write("3. sayıyı giriniz: ");
        int sayi3 = int.Parse(Console.ReadLine());

        int result;

        if(sayi1<sayi2)
        {
           result= sayi1;
           sayi1= sayi2;
           sayi2=result; 
        }
        if(sayi1<sayi3)
        {
            result=sayi1;
            sayi1=sayi3;
            sayi3=result;
        }
        if(sayi2<sayi3)
        {
            result=sayi2;
            sayi2=sayi3;
            sayi3=result;
        }
        System.Console.WriteLine("Sayılar büyükten küçüğe sıralanışı: ");
        System.Console.WriteLine(sayi1);
        System.Console.WriteLine(sayi2);
        System.Console.WriteLine(sayi3);
    }
}
