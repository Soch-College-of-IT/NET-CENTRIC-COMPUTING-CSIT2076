using System;

class leapyear
{
    static void Main(string[] args)
    {
        int year;
        Console.Write("Enter the year: ");
        string input = Console.ReadLine();
        year = Convert.ToInt32(input);

        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            Console.WriteLine("{0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year.", year);
        }
    }
}
