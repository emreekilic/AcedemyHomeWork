using System;

namespace Zooling_Application;

public class Animal
{
    public Animal(string names, int age, string tür)
    {
        Names = names;
        Age = age;
        Tür = tür;
    }

public string Names { get; set; }
public int Age { get; set; }
public string Tür { get; set; }

public virtual void DisplayCount()
{
    System.Console.WriteLine($"Ad: {Names}\nYaşı: {Age}\nTürü: {Tür}");
}
public virtual void MakeSound()
{
    System.Console.WriteLine(" ");
}

}
