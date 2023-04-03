using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    public class EventsDemo
    {
        public delegate int ArithmeticDelegate(int a, int b);
        public event ArithmeticDelegate ArithmeticEvent;

        public void RaiseEvent(int a, int b)
        {
            ArithmeticEvent(a, b);
            Console.WriteLine("Event Raised");
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            EventsDemo obj = new EventsDemo();
            obj.ArithmeticEvent += new ArithmeticDelegate(obj.Add);
            obj.ArithmeticEvent += new ArithmeticDelegate(obj.Subtract);
            obj.RaiseEvent(12,10);
        }
    }
}