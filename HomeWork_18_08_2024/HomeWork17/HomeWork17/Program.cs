namespace HomeWork17;

class Program
{
    static void Main(string[] args)
    {
        byte myByte = 42;
        short myShort = 42;
        int myİnt = 42;
        long myLong = 42;

        Console.WriteLine("byte tipi bellekte " + sizeof(byte) + " byte kaplar.");
        Console.WriteLine("short tipi bellte " + sizeof(short) + " byte kaplar.");
        Console.WriteLine("int tipi bellekte " + sizeof(int) + " byte kaplar.");
        Console.WriteLine("long tipi bellekte " + sizeof(long) + " byte kaplar.");

    }
}
