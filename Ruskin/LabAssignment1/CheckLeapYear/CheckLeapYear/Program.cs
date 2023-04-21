using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the year (to check if it is leap or not): ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && (year % 100 !=0 || year % 400 == 0))
            {
                Console.WriteLine("{0} is a leap year!", year);
            }
            else{
                Console.WriteLine("{0} is not a leap year!", year);
            }
        }
    }
}
