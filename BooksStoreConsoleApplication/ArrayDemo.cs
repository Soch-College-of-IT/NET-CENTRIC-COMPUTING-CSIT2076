using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStoreConsoleApplication
{
    public class ArrayDemo
    {
        public void ArrayDemonstration()
        {
            // Lets declare an array
            int[] numbers = new int[] { 34, 5, 22, 65, 78, 4, 10, 15 };

            Console.WriteLine("\n\nNumbers before sort: ");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            // Sort the array
            Array.Sort(numbers);
            Console.WriteLine("\nNumbers after sort: ");
            foreach (int number in numbers)
            {
                Console.Write("{0} ", number);
            }

            // Create a new array and copy the numbers from the first array
            int[] newNumbers = new int[3];
            Array.Copy(numbers, newNumbers, 3);
            Console.WriteLine("\nNew Array of Numbers: ");
            foreach (int number in newNumbers)
            {
                Console.WriteLine(number);
            }

            // Reverse the array
            Array.Reverse(numbers);
            Console.WriteLine("\nReversed Array of Numbers: ");
            foreach (int number in numbers)
            {
                Console.Write("{0} ",number);
            }
            Console.WriteLine();
        }
    }
}
