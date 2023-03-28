using SimpleConsoleApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStoreConsoleApplication
{
    internal class Program
    {
        // this is an entry point of the program
        static void Main(string[] args)
        {

            // Lets create a object of Books class
            Books book1 = new Books();

            // Lets assign values to the object using properties (setters)
            book1.ISBN = 456;
            book1.Name = "C# Programming";
            book1.Author = "Harry Daniel";
            book1.Publisher = "MacGraw Hill";

            // Lets print the values using method
            book1.printBooksDetails();

            // Lets create a object of Books class and assign values using constructor
            Books book2 = new Books(123, ".Net Programming", "Robin Crook", "Graham Bell Publishing House");

            // Lets print the values using properties (getters)
            Console.WriteLine("ISBN : {0}", book2.ISBN);
            Console.WriteLine("Name: {0}", book2.Name);
            Console.WriteLine("Author: {0}", book2.Author);
            Console.WriteLine("Publisher: {0}", book2.Publisher);
        }
    }
}
