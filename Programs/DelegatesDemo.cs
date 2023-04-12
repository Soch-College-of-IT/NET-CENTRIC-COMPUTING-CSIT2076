using System;

namespace Programs
{
    internal class DelegatesDemo
    {
        public delegate int ArithmeticDelegate(int a, int b);

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a*b;
        }

        public int Divide(int a, int b)
        {
            return a/b;
        }

        public void Test()
        {
            ArithmeticDelegate arithmeticDelegate = Add;
            Console.WriteLine(arithmeticDelegate(10, 20));

            arithmeticDelegate = Subtract;
            Console.WriteLine(arithmeticDelegate(10, 20));

            arithmeticDelegate = Multiply;
            Console.WriteLine(arithmeticDelegate(10, 20));

            arithmeticDelegate = Divide;
            Console.WriteLine(arithmeticDelegate(10, 20));
        }

        static void Main(string[] args)
        {
            DelegatesDemo delegatesDemo = new DelegatesDemo();
            delegatesDemo.Test();
        }
    }
}
