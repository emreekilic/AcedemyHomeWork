using System;

namespace Zooling_Application;

public class Lion : Animal
{
    public Lion(string names, int age, string tür) : base(names, age, tür)
    {
    }
    public override void MakeSound()
    {
        Console.Write("Aslan kükredi");
        base.MakeSound();

    }

}
