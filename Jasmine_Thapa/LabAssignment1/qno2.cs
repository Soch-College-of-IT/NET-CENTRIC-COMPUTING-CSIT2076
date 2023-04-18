using System;
namespace CheckLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());  //int.Parse(): This method takes a string as input and tries to convert it to an integer. If the string contains a valid integer value, the method returns that value as an integer. If the string cannot be converted to an integer, an exception is thrown.
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) Console.WriteLine("{0} is a Leap Year.", Year);
            else Console.WriteLine("{0} is not a Leap Year.", Year);
            Console.ReadLine();
        }
    }
}
