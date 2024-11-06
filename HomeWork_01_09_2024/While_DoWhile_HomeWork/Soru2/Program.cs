namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        #region 2.Soru
    System.Console.WriteLine("Lütfen bir metin giriniz: ");     
    string metin = Console.ReadLine();
    string sonuc = ""; //sonucun tutulacağı değişken
    int i = 0; //başlangıç indexi

    //While döngüsü ile metindeki her karakteri kontrol et
    while (i < metin.Length)
    {
      char karakter = metin[i]; //Metinde o andaki karakter


      if (char.IsLetter(karakter)) // Eğer karakter bir harfse büyük harfe çevir
        sonuc += char.ToUpper(karakter); //büyük hrfe çevir ve ekle
      else
        sonuc += karakter; //harf değilse olduğu gibi ekler 

      i++; //bir sonraki harfe geçer.
    }

    Console.WriteLine(sonuc);
    #endregion
       
    }
}
