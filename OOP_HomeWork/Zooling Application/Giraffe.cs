using System;

namespace Zooling_Application;

public class Giraffe : Animal
{
    public Giraffe(string names, int age, string tür) : base(names, age, tür)
    {
    }
    public override void MakeSound()
    {
        Console.Write("Zürafa sesi çıkardı");
        base.MakeSound();
    }
}
