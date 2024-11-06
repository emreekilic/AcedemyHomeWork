namespace Soru9;

class Program
{
    static void DisplayArray(int[] dizi)
    {
        foreach (int cuurnetNumber in dizi)
        {
            System.Console.WriteLine(cuurnetNumber);
        }
    }
    static int[] GetPozitiveNumbers(int[] dizi)
    {
        int count = 0;
        foreach (int currnetNumber in dizi)
        {
            if (currnetNumber > 0) count++;

        }
        int[] pozitiveNumbers = new int[count];
        int index = 0;
        foreach (int currnetNumber in dizi)
        {
            if (currnetNumber > 0)
            {
                pozitiveNumbers[index] = currnetNumber;
                index++;
            }
        }
        Array.Reverse(pozitiveNumbers);
        return pozitiveNumbers;

    }
    static void Main(string[] args)
    {
        int[] dizi = { 3, -5, 1, -6, 9, -3, -2, 8 };
        DisplayArray(dizi);
        int[] pozitiveNumberCount = GetPozitiveNumbers(dizi);

        int index = 0;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] > 0)
            {
                dizi[i] = pozitiveNumberCount[index];
                index++;
            }
        }
        Console.WriteLine("************");
        DisplayArray(dizi);


    }
}
