using System;
namespace FirstAssignment
{

    class Qno2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

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

}