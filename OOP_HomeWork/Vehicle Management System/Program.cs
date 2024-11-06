namespace Vehicle_Management_System;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("BMW", "520", 2015, 5);
        car.DisplayCount();
        System.Console.WriteLine("***********");
        Motorcyle motorcyle = new Motorcyle("CFG", "FFR", 2020, "Yan Sepet");
        motorcyle.DisplayCount();
        System.Console.WriteLine("************");
        Bicyle bicyle = new Bicyle("BMW", "Yariss", 2023);
        bicyle.DisplayCount();
    }
}
