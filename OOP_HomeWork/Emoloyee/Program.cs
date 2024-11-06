namespace Emoloyee;

class Program
{
    static void Main(string[] args)
    {
        Manager manager= new Manager("Emre Kılıç",34,70000,5);
        manager.Count();
        System.Console.WriteLine("********************");
        Developer developer= new Developer("Emre Kılıç",3,50000,".Net & C#");
        developer.Count();
        System.Console.WriteLine("*********************");
        İntern intern= new İntern("Emre Kılıç",99,10000);
        intern.Count();
    }
}
