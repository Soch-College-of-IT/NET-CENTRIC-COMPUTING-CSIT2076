using SimpleConsoleApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BooksStoreConsoleApplication
{
    internal class Program
    {
        // this is an entry point of the program
        static void Main(string[] args)
        {
            /* [multiline comments]
            // Lets create a object of Books class [single line comment]
            Books book1 = new Books();

            // Lets assign values to the object using properties (setters)
            book1.ISBN = 456;
            book1.Name = "C# Programming";
            book1.Author = "Harry Daniel";
            book1.Publisher = "MacGraw Hill";
            book1.PublishedYears = new int[4] { 2000,2002,2010,2022};
            */

            // Simplified version of object creation with initialization
            Books book1 = new Books()
            {
                ISBN = 456,
                Name = "C# Programming",
                Author = "Harry Daniel",
                Publisher = "MacGraw Hill",
                PublishedYears = new int[4] { 2000, 2002, 2010, 2022 }
            };

            // Lets print the values using method
            book1.printBooksDetails();

            // Lets create a object of Books class and assign values using constructor
            Books book2 = new Books(123, ".Net Programming", "Robin Crook", "Graham Bell Publishing House",new int[7] {1992,1995,2000,2005,2010,2015,2020});

            // Lets print the values using properties (getters)
            // WriteLine prints single statement and adds new line
            Console.WriteLine();
            Console.WriteLine("ISBN : {0}", book2.ISBN);
            Console.WriteLine("Name: {0}", book2.Name);
            Console.WriteLine("Author: {0}", book2.Author);
            Console.WriteLine("Publisher: {0}", book2.Publisher);
            // Write prints single statement and does not add new line
            Console.Write("Published Years: ");

            // for loop similar syntax of C,C++. Length is properties of array, which gives size of array
            for (int i=0;i<book2.PublishedYears.Length;i++)
            {
                Console.Write("{0}, ", book2.PublishedYears[i]);
            }

            ArrayDemo arrayDemo = new ArrayDemo();
            arrayDemo.ArrayDemonstration();

            StringDemo stringDemo = new StringDemo();
            stringDemo.StringDemonstration();

            // Accessing class elements through Indexer 
            IndexersDemo Team = new IndexersDemo();
            Team[0] = "Ram";
            Team[1] = "Shyam";
            Team[2] = "Hari";
            Team[3] = "Gita";
            Team[4] = "Sita";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Team[i]);
            }
        }
    }
}
