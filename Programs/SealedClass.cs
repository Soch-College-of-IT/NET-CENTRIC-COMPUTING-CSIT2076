using System;

namespace Programs
{
    internal class SealedClass
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method1();
        }
    }
}

public sealed class Utilities
{
    public int Add(int x, int y)
    {
        return x + y;
    }
}

public class DerivedClass : Utilities  // gives compilation error
{
    public void Method1()
    {
        Console.WriteLine("DerivedClass.Method1");
    }
}
