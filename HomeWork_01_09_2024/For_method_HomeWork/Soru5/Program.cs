namespace Soru5;

class Program
{
   static void Main(string[] args)
   {
      Console.WriteLine("1'den 100'e kadar olan asal sayılar:");

      for (int sayi = 2; sayi <= 100; sayi++)
      {
         bool asalMi = true;


         for (int i = 2; i < sayi - 1; i++)
         {
            if (sayi % i == 0)
            {
               asalMi = false;
               break;
            }
         }

         if (asalMi)
         {
            Console.WriteLine($"{sayi} asal sayıdır.");
         }
         else
         {
            System.Console.WriteLine($"{sayi} asal değildir.");
         }
      }


   }
}
