namespace Soru15;

class Program
{
    static void Main(string[] args)
    {
       Random random= new Random();
        int[] dizi = new int[10];
        for(int i=0; i<10; i++)
        {
            dizi[i] = random.Next(0,20);
        }
        Console.WriteLine("Dizi: "+ string.Join(",", dizi));
        int[] tekler = new int[dizi.Length];
        int index =0;

        for(int i=0; i<10; i++) //Tekleri bulup ayrı diziye aktardığımız döngü.
        {
            if(dizi[i]%2!=0)
            {
                tekler[index] = dizi[i];
                index++;
            }
        }
        Array.Sort(tekler,0,index);
        index=0;
        for(int i =0; i<dizi.Length; i++) //Tek sayıları orijinal diziye geri alıyoruz.
        {
            if(dizi[i]%2 !=0)
            {
                dizi[i] =tekler[index];
                index++;
            }
        }
        Console.WriteLine("Dizinin son hali: "+ string.Join(",",dizi));
    }
}
