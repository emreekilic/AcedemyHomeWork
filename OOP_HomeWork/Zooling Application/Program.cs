namespace Zooling_Application;

class Program
{
    static void Main(string[] args)
    {
        Elephant elephant = new Elephant("Fikri", 21, "Fil");
        elephant.DisplayCount();
        elephant.MakeSound();
        System.Console.WriteLine("****************");
        Lion lion = new Lion("Fikri", 21, "Aslan");
        lion.DisplayCount();
        lion.MakeSound();
        System.Console.WriteLine("*****************");
        Giraffe giraffe = new Giraffe("Fikri", 21, "Zürafa");
        giraffe.DisplayCount();
        giraffe.MakeSound();
    }
}
