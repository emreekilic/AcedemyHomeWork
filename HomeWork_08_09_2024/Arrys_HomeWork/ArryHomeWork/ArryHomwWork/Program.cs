namespace ArryHomwWork;

class Program
{
    static void Main(string[] args)
    {
        #region 1.Soru

        // Random random= new Random();
        // int [] dizi = new int[10];
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i]=random.Next(1,100);
        // }
        // System.Console.WriteLine("Oluşturulan dizi: ");
        // foreach (int sayi in dizi)
        // {
        //     Console.Write(sayi + " ");
        // }
        // System.Console.WriteLine();

        // System.Console.WriteLine("Kendinden önceki ve sonraki büyük sayılar: ");
        // for (int i =1; i<dizi.Length-1;i++)            
        // {
        //     if (dizi[i]>dizi[i-1]&&dizi[i]>dizi[i+1])
        //     {
        //         System.Console.Write(dizi[i]+ " ");
        //     }
        // }
        // Console.ReadLine();
        #endregion

        #region 2.Soru
            // int[]sayilar = new int[10];
            // int ciftSayilar= new int[10];
            // int ciftSayiSayaci=0;
            // System.Console.WriteLine("Lütfen 10 adet sayı giriniz: ");
            // for (int i = 0; i <sayilar.Length; i++)     
            // {
            //   Console.Write("{0}.sayı:",i+1);
            //   sayilar[i]=Convert.ToInt32(Console.ReadLine());
            //   if (sayilar[i]%2==0)
            //   {
            //     ciftSayilar[ciftSayiSayaci] = sayilar[i];
            //     ciftSayiSayaci++;
            //   }  
            // }
            // for (int i = 0; i < ciftSayiSayaci; i++)
            // {
            //     for (int j = 0; j < ciftSayiSayaci-i-1; j++)
            //     {
            //         if (ciftSayilar[j]>ciftSayilar[j+1])
            //         {
            //             int temp=ciftSayilar[i];
            //             ciftSayilar[j]=ciftSayilar[j+1];
            //             ciftSayilar[j+1]=temp;
            //         }
            //     }
            // }
            // System.Console.WriteLine("Sıralanmış çift sayılar:");
            // for (int i = 0; i < ciftSayiSayaci; i++)
            // {
            //     System.Console.WriteLine(ciftSayilar[i]+" ");
            // }
        #endregion

        #region 3.Soru
            // Random random=new Random();
            // int[]dizi=new int[10];
            // for (int i = 0; i <dizi.Length; i++)
            // {
            //     dizi[i]=random.Next(-100,100);

            // }
            // List<int>pozitifSayilar = new();
            // List<int>negatifSayilar =new();

            // int index=0;
            // while (index<dizi.Length)
            // {
            //     if (dizi[index]>0)
            //     {
            //         pozitifSayilar.Add(dizi[index]);
            //     }
            //     else if (dizi[index]<0)
            //     {
            //         negatifSayilar.Add(dizi[index]);
            //     }
            //     index++;
            // }
            // System.Console.WriteLine("Oluşturulan dizi: ");
            // foreach (int sayi in dizi)
            // {
            //     System.Console.Write(sayi+" ");
            // }
            // System.Console.WriteLine("Pozitif sayılar: ");
            // foreach (int sayi in pozitifSayilar)
            // {
            //     System.Console.Write(sayi+" ");
            // }
            // System.Console.WriteLine("Negatif Sayılar: ");
            // foreach (int item in negatifSayilar)
            // {
            //     Console.Write(item +" ");
            // }
        #endregion

        #region 10. Soru

        // int[] dizi = { 1, 4, 7, 21, 33, 5, 667, 43, 66, 22 };
        // int j = 0;
        // int[] result = new int[dizi.Length];
        // for (int i = result.Length - 1; i >= 0; i--)
        // {
        //     result[j] = dizi[i];
        //     j++;
        // }
        // for (int i = 0; i < result.Length; i++)
        // {
        //     Console.Write(result[i] + ",");
        // }
        // Console.WriteLine("Dizinin orijinal hali:");
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     Console.Write(dizi[i] + ",");
        // }
        // Console.Read();
        #endregion

        #region 11.Soru
        // System.Console.Write("Bir kelime giriniz => ");
        // string girKelime = Console.ReadLine();

        // char[] kelDizi = girKelime.ToCharArray();
        // Array.Reverse(kelDizi);
        // string çevDiz = new string(kelDizi);

        // foreach (var item in çevDiz)
        // {
        //     System.Console.Write(item);

        #endregion

        #region 12.Soru
        // 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en sık tekrar eden elemanı bulan ve kaç defa tekrarlandığını ekrana yazdıran bir program yazın.Bu işlemi bir foreach döngüsü ile gerçekleştirin.

        // int[] dizi = new int[20];
        // Random rnd = new Random();
        // int sayaç = 1;

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i] = rnd.Next(1, 11);

        // }
        // System.Console.WriteLine("Random dizimiz");
        // System.Console.WriteLine("---------------------------------------------------");
        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine($"{sayaç}. ==> {item}");
        //     sayaç++;
        // }

        // int fazlaTekEleman = dizi[0];
        // int tekrareleman = 0;

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     int x = dizi[i];
        //     int teksay = 0;

        //     foreach (var eleman in dizi)
        //     {
        //         if (eleman == x)
        //         {
        //             teksay++;
        //         }
        //     }

        //     if (teksay > tekrareleman)
        //     {
        //         fazlaTekEleman = x;
        //         tekrareleman = teksay;
        //     }
        // }

        // System.Console.WriteLine($"En çok tekrar eden eleman {fazlaTekEleman} = {tekrareleman} kadar tekrarlanıyor.");


        #endregion

    }
}
