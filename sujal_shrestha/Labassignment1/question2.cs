using System;

class Program
{
    static void Main(string[] args)
    {
        int year;
        Console.WriteLine("Enter a year: ");
        year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine("{0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year.", year);
        }
    }
}
