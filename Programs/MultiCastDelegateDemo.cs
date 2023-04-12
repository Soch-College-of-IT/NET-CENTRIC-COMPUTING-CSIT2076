using System;

namespace Programs
{
    internal class MultiCastDelegateDemo
    {
        public delegate void ArithmeticDelegate(int a, int b);

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine(a/b);
        }

        public void Test()
        {
            ArithmeticDelegate arithmeticDelegate = Add;
            arithmeticDelegate += Multiply;
            arithmeticDelegate += Subtract;
            arithmeticDelegate += Divide;
            arithmeticDelegate(10, 20);
        }

        static void Main(string[] args)
        {
            MultiCastDelegateDemo multiCastDelegateDemo = new MultiCastDelegateDemo();
            multiCastDelegateDemo.Test();
        }
    }
}