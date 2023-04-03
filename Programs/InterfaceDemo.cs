// interface example
using System;

namespace Programs
{
    internal class InterfaceDemo
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method1();
        }
    }

    public interface IUtilities
    {
        int Add(int x, int y);
    }

    public class DerivedClass : IUtilities
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public void Method1()
        {
            Console.WriteLine("DerivedClass.Method1");
        }
    }
}