namespace Soru14;

class Program
{
    static void Main(string[] args)
    {
        Random random=new Random();
        int []dizi= new int[20];
        for (int i = 0; i <dizi.Length; i++)
        {
          dizi[i]=random.Next(1,20);
        }
        int toplam=0;
        for (int i = 0; i <dizi.Length; i++)
        {
            if (dizi[i]%3==0)
            {
                toplam+=dizi[i];
            }
        }
        System.Console.WriteLine("3'e bölünen sayıların toplamı: ");
        for (int i = 1; i <= toplam; i++)
        {
            Console.Write(i);
            if (i % 5==0)
            {
                Console.WriteLine(" ");
            }
        }
        System.Console.WriteLine();
    }
}
